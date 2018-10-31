
using SLua;
using UnityEngine;

[CustomLuaClass]
[AddComponentMenu("Component/FSmooth Follow")]
public class FSmootFollow : MonoBehaviour
{
    public Transform target;
    public float distance = 10.0f;
    public float height = 5.0f;
    public float heightDamping = 2.0f;
    public float rotationDamping = 3.0f;

    void LateUpdate()
    {
        if (null == target)
            return;

        var wantedRotationAngle = target.eulerAngles.y;
        var wantedHeight = target.position.y + height;


        var currentRotationAngle = transform.eulerAngles.y;
        var currentHeight = transform.position.y;
        
        // Damp the rotation around the y-axis
        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);
        
        // Damp the height
        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

        // Convert the angle into a rotation

        //下面是原始代码。
        //var currentRotation = Quaternion.Euler (0, currentRotationAngle, 0);

        //这里是我修改的，直接让它等于1，
        //摄像机就不会旋转。
        var currentRotation = 1;

        // Set the position of the camera on the x-z plane to:
        // distance meters behind the target
        transform.position = target.position;
        transform.position -= currentRotation * Vector3.forward * distance;

        // Set the height of the camera
        transform.position.Set(transform.position.x, currentHeight, transform.position.z);

        // Always look at the target
        transform.LookAt(target);

    }
}
