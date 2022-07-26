using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{
    [SerializeField] GameObject yellowDoor;
    [SerializeField] GameObject redDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RedKey"))
        {
            GameObject redDoor = GameObject.Find("RedDoor");
            DoorScript script = redDoor.GetComponent<DoorScript>();
            script.OpenDoor();
            Destroy(other.gameObject);
        }

        if (other.CompareTag("YellowKey"))
        {
            GameObject yellowDoor = GameObject.Find("YellowDoor");
            DoorScript script = yellowDoor.GetComponent<DoorScript>();
            script.OpenDoor();
            Destroy(other.gameObject);
        }
    }
}
