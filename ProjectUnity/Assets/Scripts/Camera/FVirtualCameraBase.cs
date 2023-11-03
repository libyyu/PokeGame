using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class FVirtualCameraBase : MonoBehaviour
{
    public enum CameraMode
    {
        FreePerspective,
        FirstPerson,
        ThirdPerson,
        OverLook,
        Quarter,
    }


    #region �ֶ�
    protected FVirtualCameraManager cmvCamManager;

    [Header("Cinemachine")]
    protected CinemachineVirtualCamera virtualCamera;

    protected CameraMode cameraMode = CameraMode.FreePerspective;
    #endregion

    #region �������ں���
    protected virtual void Awake()
    {
        cmvCamManager = FVirtualCameraManager.Instance;
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }
    #endregion

    #region ����
    /// <summary>
    /// �Ƿ񼤻�
    /// </summary>
    /// <param name="isEnabled">�Ƿ񼤻�</param>
    public void SetEnable(bool isEnabled = false)
    {
        virtualCamera.enabled = isEnabled;
        enabled = isEnabled;
    }
    #endregion
}
