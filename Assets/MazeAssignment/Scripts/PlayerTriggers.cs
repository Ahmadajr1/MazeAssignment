using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTriggers : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("You lost");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        string keyTag = other.tag;

        if (other.CompareTag("RedKey") || other.CompareTag("YellowKey") || other.CompareTag("GreenKey"))
        {
            string matchingDoorTag = IdenfifyMatchingDoorTag(keyTag);
            OpenAllMatchingDoors(matchingDoorTag);
            Destroy(other.gameObject);
        }
    }

    private string IdenfifyMatchingDoorTag(string keyTag)
    {
        string matchingDoorTag;

        switch (keyTag)
        {
            case "RedKey":
                matchingDoorTag = "RedDoor";
                break;
            case "YellowKey":
                matchingDoorTag = "YellowDoor";
                break;
            case "GreenKey":
                matchingDoorTag = "GreenDoor";
                break;
            default:
                matchingDoorTag = "Unknown";
                break;
        }
        return matchingDoorTag;
    }

    private void OpenAllMatchingDoors(string doorTag)
    {
        GameObject[] doors = GameObject.FindGameObjectsWithTag(doorTag);
        foreach (GameObject door in doors)
        {
            DoorScript doorScript = door.GetComponent<DoorScript>();
            doorScript.OpenDoor();
        }
    }
}
