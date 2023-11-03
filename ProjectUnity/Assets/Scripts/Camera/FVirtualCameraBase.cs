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


    #region 字段
    protected FVirtualCameraManager cmvCamManager;

    [Header("Cinemachine")]
    protected CinemachineVirtualCamera virtualCamera;

    protected CameraMode cameraMode = CameraMode.FreePerspective;
    #endregion

    #region 生命周期函数
    protected virtual void Awake()
    {
        cmvCamManager = FVirtualCameraManager.Instance;
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }
    #endregion

    #region 激活
    /// <summary>
    /// 是否激活
    /// </summary>
    /// <param name="isEnabled">是否激活</param>
    public void SetEnable(bool isEnabled = false)
    {
        virtualCamera.enabled = isEnabled;
        enabled = isEnabled;
    }
    #endregion
}
