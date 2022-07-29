using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController playerController;
    GameObject cameraTarget;

    private float speed = 10;
    private Vector3 horizontalMovement;
    private Vector3 verticalMovement;
    private Vector3 movement;

    private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        playerController = gameObject.GetComponent<CharacterController>();
        cameraTarget = GameObject.FindGameObjectWithTag("Camera Target");
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = cameraTarget.transform.right * Input.GetAxisRaw("Horizontal");
        verticalMovement = cameraTarget.transform.forward * Input.GetAxisRaw("Vertical");

        //To disable player input when off ground
        if (playerController.isGrounded)
        {
            movement = (horizontalMovement + verticalMovement) * speed;
        }
        else
            movement = Vector3.zero;
    }

    private void FixedUpdate()
    {
        Move();
    }

    // Handles player's movement 
    private void Move()
    {
            playerController.SimpleMove(movement);
    }
}
