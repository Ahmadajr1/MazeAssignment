using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    bool isTopViewEnabled = true;
    GameObject cameraTarget;
    private Vector3 topViewPosition;
    private Vector3 thirdPersonViewPosition;

    private void Start()
    {
        cameraTarget = GameObject.FindGameObjectWithTag("Camera Target");
    }

    private void Update()
    {
    }

    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            isTopViewEnabled = !isTopViewEnabled;
        }
        AdjustCameraPositionAndXRotation();

        if(!isTopViewEnabled)
            AdjustCameraYRotation();
    }

    private void AdjustCameraPositionAndXRotation()
    {
        topViewPosition = cameraTarget.transform.position + new Vector3(0, 20, 0);
        thirdPersonViewPosition = cameraTarget.transform.localPosition + new Vector3(0, -3, -6);

        if (isTopViewEnabled)
        {
            transform.rotation = Quaternion.Euler(85, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
            transform.position = topViewPosition;
            cameraTarget.transform.rotation = Quaternion.Euler(Vector3.zero);
        }
        else
        {
            transform.rotation = Quaternion.Euler(30, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
            transform.localPosition = thirdPersonViewPosition;
        }
    }

    private void AdjustCameraYRotation()
    {
        float sensitivity = 10;
        float yRotation = 0;

        yRotation = cameraTarget.transform.eulerAngles.y + Input.GetAxisRaw("Mouse X") * sensitivity;
        cameraTarget.transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
