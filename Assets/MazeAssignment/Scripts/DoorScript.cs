using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    bool keyTriggered = false;
    float speed = 2;

    // Update is called once per frame
    void Update()
    {
        if (keyTriggered)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            if (transform.position.y < -1.2)
            {
                keyTriggered = false;
                gameObject.GetComponent<BoxCollider>().isTrigger = true;
            }
        }
    }

    public void OpenDoor()
    {
        keyTriggered = true;
        Debug.Log($"{gameObject.name} opened");
    }
}
