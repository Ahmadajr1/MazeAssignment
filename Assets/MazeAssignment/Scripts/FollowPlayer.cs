using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    bool isTopViewEnabled = true;
    GameObject player;
    private Vector3 topViewPosition;
    private Vector3 thirdPersonViewPosition;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            isTopViewEnabled = !isTopViewEnabled;
        }
        AdjustCameraPositionAndRotation();
    }

    private void AdjustCameraPositionAndRotation()
    {
        topViewPosition = player.transform.position + new Vector3(0, 15, 0);
        thirdPersonViewPosition = player.transform.position + new Vector3(0, 3, -4);

        if (isTopViewEnabled)
        {
            transform.rotation = Quaternion.Euler(new Vector3(75, 0, 0));
            transform.position = topViewPosition;
        }
        else 
        {
            transform.rotation = Quaternion.Euler(new Vector3(30, 0, 0));
            transform.position = thirdPersonViewPosition;
        }
    }
}
