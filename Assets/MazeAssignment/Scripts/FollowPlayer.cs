using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    float cameraYPosition = 15;

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, cameraYPosition, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
