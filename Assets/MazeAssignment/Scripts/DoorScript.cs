using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    bool keyTriggered = false;
    float speed = 1;

    // Update is called once per frame
    void Update()
    {
        if (keyTriggered)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            if (transform.position.y < 0)
            {
                keyTriggered = false; // To stop the door from moving down further
                gameObject.GetComponent<BoxCollider>().isTrigger = true;
            }
        }
    }

    public void OpenDoor()
    {
        keyTriggered = true;
    }
}
