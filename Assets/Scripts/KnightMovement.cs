using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KnightMovement : MonoBehaviour
{
    //Variables
    [SerializeField] float moveSpeed = 2;
    [SerializeField] float jumpSpeed = 5f;

    Vector2 moveInput;
    Rigidbody2D myRigidbody;
    BoxCollider2D myFoot;



    //Event functions
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myFoot = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        HorizontalMove();
    }



    //Methods
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    void HorizontalMove()
    {
        myRigidbody.velocity = new Vector2(moveInput.x * moveSpeed, myRigidbody.velocity.y);
    }
    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            if (myFoot.IsTouchingLayers(LayerMask.GetMask("Ground")))
            {
                myRigidbody.velocity += new Vector2(myRigidbody.velocity.x, jumpSpeed);
            }
        }
    }
}
