using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;

    private Vector2 movement;

    void OnMove(InputValue value) 
    {
        Debug.Log("Move");

        movement = value.Get<Vector2>();

        rb.AddForce(transform.right * 5000 * movement.x);
    }

    void OnJump()
    {
        Debug.Log("Jump");

        rb.AddForce(transform.up * 25000);
    }

}
