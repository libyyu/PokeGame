using Cinemachine;
using UnityEngine;

//[RequireComponent(typeof(CinemachineCollider))]
public class FVirtualCamera_Free : FVirtualCameraBase
{
    #region �ֶ�

    [Header("Cinemachine")]
    private Cinemachine3rdPersonFollow camera3rdPersonFollow;

    private float _cinemachineTargetYaw;
    private float _cinemachineTargetPitch;
    private const float _threshold = 0.01f;

    [Header("Cinemachine_3rd")]
    [Tooltip("����������ƶ����Ƕ�")]
    public float topClamp_Free = 89.0f;
    [Tooltip("����������ƶ����Ƕ�")]
    public float bottomClamp_Free = -30.0f;
    [Tooltip("��ת�ٶ�")]
    public float rotationSpeed = 1.0f;
    [Tooltip("����Ķ�������������ͷ������ʱ����΢�����λ��")]
    public float cameraAngleOverride = 0.0f;
    [Tooltip("�������ʼ����")]
    public float cameraDistance = 4.0f;

    #region ���
    private float mouseX;
    private float mouseY;
    #endregion

    #region ��ת
    [Header("Controller Input")]
    public KeyCode resetCamera = KeyCode.P;

    public KeyCode lockCameraPositionY = KeyCode.Alpha9;
    public bool lockCameraPositionY_ = false;

    public KeyCode lockCameraPositionX = KeyCode.Alpha8;
    public bool lockCameraPositionX_ = false;

    public bool isMoveCamera_ = false;

    public KeyCode isMouseBtnControlCamera = KeyCode.RightControl;
    public bool isMouseBtnControlCamera_ = true;

    public bool IsMouseBtnControlCamera
    {
        get
        {
            if (isMouseBtnControlCamera_)
            {
                if (Input.GetMouseButton(0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
    }
    #endregion    

    #region ����
    public KeyCode isMouseScrollZoom = KeyCode.RightAlt;
    public bool isMouseScrollZoom_ = true;

    [Header("Zoom")]
    public float scrollSpeed = 10.0f;
    [Range(-50.0f, 5.0f)]
    public float minZoom = -50.0f;
    [Range(5.0f, 50.0f)]
    public float maxZoom = 50.0f;
    private float zoomCameraDistance;
    #endregion
    #endregion

    #region �������ں���
    protected override void Awake()
    {
        base.Awake();
        camera3rdPersonFollow = virtualCamera.GetCinemachineComponent<Cinemachine3rdPersonFollow>();
        ResetCamera();
    }

    void LateUpdate()
    {
        if (cmvCamManager.followTarget_Free == null)
        {
            if (this.virtualCamera.Follow == null)
            {
                this.virtualCamera.Follow = null;
            }

            if (this.virtualCamera.LookAt == null)
            {
                this.virtualCamera.LookAt = null;
            }

            return;
        }

        if (this.virtualCamera.Follow == null)
        {
            this.virtualCamera.Follow = cmvCamManager.followTarget_Free;
        }

        if (this.virtualCamera.LookAt == null)
        {
            this.virtualCamera.LookAt = cmvCamManager.followTarget_Free;
        }

        if (_cinemachineTargetYaw == 0)
        {
            _cinemachineTargetYaw = cmvCamManager.followTarget_Free.transform.rotation.eulerAngles.y;
        }

        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        SetInput();
        RotationCamera();
        ZoomCamera();
        MoveCamera();

        if (Input.GetKeyDown(resetCamera))
        {
            ResetCamera();
        }
    }

    void OnValidate()
    {
        maxZoom = Mathf.Max(minZoom, maxZoom);
    }
    #endregion

    #region ����

    #region �����л�
    private void SetInput()
    {
        //�����Ҳ�Alt���л�����/���Y������
        if (Input.GetKeyDown(isMouseScrollZoom))
        {
            isMouseScrollZoom_ = !isMouseScrollZoom_;
        }

        //�����Ҳ�Ctrl���л�����������/����ƶ���ת
        if (Input.GetKeyDown(isMouseBtnControlCamera))
        {
            isMouseBtnControlCamera_ = !isMouseBtnControlCamera_;
        }

        //����9���л���ֹY����ת����ˮƽ��ת��
        if (Input.GetKeyDown(lockCameraPositionY))
        {
            lockCameraPositionY_ = !lockCameraPositionY_;
        }

        //����8���л���ֹX����ת������ֱ��ת��
        if (Input.GetKeyDown(lockCameraPositionX))
        {
            lockCameraPositionX_ = !lockCameraPositionX_;
        }

        //��������м�/�Ҽ��������ƶ�����������Ŀ�����λ��
        if (Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {
            isMoveCamera_ = true;
        }
        else if (Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(2))
        {
            isMoveCamera_ = false;
        }
    }
    #endregion

    #region ��ת
    /// <summary>
    /// ��ת�����
    /// </summary>
    private void RotationCamera()
    {
        Vector2 look = new Vector2(mouseX * rotationSpeed, -mouseY * rotationSpeed);

        if (look.sqrMagnitude >= _threshold)
        {
            if (IsMouseBtnControlCamera)
            {
                if (!lockCameraPositionX_)
                {
                    _cinemachineTargetYaw += look.x;
                }

                if (!lockCameraPositionY_)
                {
                    _cinemachineTargetPitch += look.y;
                }
            }
        }

        _cinemachineTargetYaw = ClampAngle(_cinemachineTargetYaw, float.MinValue, float.MaxValue);
        _cinemachineTargetPitch = ClampAngle(_cinemachineTargetPitch, bottomClamp_Free, topClamp_Free);
        cmvCamManager.followTarget_Free.transform.rotation = Quaternion.Euler(_cinemachineTargetPitch + cameraAngleOverride, _cinemachineTargetYaw, 0.0f);
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360f) { angle += 360f; }
        if (angle > 360f) { angle -= 360f; }
        return Mathf.Clamp(angle, min, max);
    }
    #endregion

    #region ����
    /// <summary>
    /// ��������������Ŀ�����
    /// </summary>
    private void ZoomCamera()
    {
        if (isMouseScrollZoom_)
        {
            zoomCameraDistance = camera3rdPersonFollow.CameraDistance - Input.mouseScrollDelta.y * scrollSpeed * Time.deltaTime;
        }
        else
        {
            zoomCameraDistance = camera3rdPersonFollow.CameraDistance - mouseY * scrollSpeed * Time.deltaTime;
        }

        camera3rdPersonFollow.CameraDistance = Mathf.Clamp(zoomCameraDistance, minZoom, maxZoom);
    }
    #endregion

    #region �ƶ�
    private void MoveCamera()
    {
        if (isMoveCamera_)
        {
            Vector3 offset = new Vector3(-mouseX, mouseY, 0);
            camera3rdPersonFollow.ShoulderOffset += offset * 0.5f;
        }
    }
    #endregion

    #region ����
    /// <summary>
    /// ���������
    /// </summary>
    private void ResetCamera()
    {
        camera3rdPersonFollow.CameraDistance = cameraDistance;
        camera3rdPersonFollow.ShoulderOffset = Vector3.zero;
    }
    #endregion
    #endregion
}
