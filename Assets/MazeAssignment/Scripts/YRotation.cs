using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YRotation : MonoBehaviour
{

    [SerializeField] float rotationSpeed = 100;
    [SerializeField] private bool inverted = false;

    private void Start()
    {
        rotationSpeed *= inverted ? -1 : 1;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
