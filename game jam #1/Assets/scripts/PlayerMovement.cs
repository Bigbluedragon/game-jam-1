using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;

    public Rigidbody2D rb;

    private Vector2 boxSize = new Vector2(0.1f, 1f);
    private Vector2 moveDirection;
   
    void Update()
    {
     
        ProcessInputs();
    }


    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float MoveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, MoveY).normalized;
    }



    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

}
