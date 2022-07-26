using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotation : MonoBehaviour
{

    [SerializeField]
    float rotationSpeed = 100;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
    }
}
