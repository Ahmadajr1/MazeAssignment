using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController playerController;

    private float speed = 8;
    private Vector3 horizontalMovement;
    private Vector3 verticalMovement;
    private Vector3 movement;


    // Start is called before the first frame update
    void Start()
    {
        playerController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = transform.right * Input.GetAxisRaw("Horizontal");
        verticalMovement = transform.forward * Input.GetAxisRaw("Vertical");

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
