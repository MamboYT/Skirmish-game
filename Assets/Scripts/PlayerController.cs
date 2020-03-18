using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float move = 0;

    public Rigidbody2D rb;
    public float moveSpeed = 10f;

    private Vector2 movement;

    void OnMove(InputValue value) 
    {
        Debug.Log("Move");

        movement = value.Get<Vector2>();
        move = movement.x;

        //move x
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);
    }

    void OnJump()
    {
;
    }

}
