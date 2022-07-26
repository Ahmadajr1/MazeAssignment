using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 1.07f;
    Rigidbody playerRB;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    // To take player's movement input 
    private void move()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal") * speed;
        float verticalMovement = Input.GetAxisRaw("Vertical") * speed;
        Vector3 movement = new Vector3(horizontalMovement, 0, verticalMovement);
        playerRB.AddForce(movement,ForceMode.Impulse);
    }
}
