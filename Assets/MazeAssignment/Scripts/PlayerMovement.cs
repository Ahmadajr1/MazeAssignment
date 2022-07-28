using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController playerController;

    [SerializeField] private float speed = 5;
    [SerializeField] private float gravity = 4;

    Vector3 horizontalMovement;
    Vector3 verticalMovement;
    Vector3 movement;


    // Start is called before the first frame update
    void Start()
    {
        playerController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    // Handles player's movement 
    private void move()
    {
        horizontalMovement = transform.right * Input.GetAxisRaw("Horizontal");
        verticalMovement = transform.forward * Input.GetAxisRaw("Vertical");
        movement = (horizontalMovement + verticalMovement).normalized * speed;
        movement.y -= gravity;
        playerController.Move(movement * Time.deltaTime);
    }
}
