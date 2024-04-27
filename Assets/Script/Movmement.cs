using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movmement : MonoBehaviour
{
    [SerializeField] private float Speed = 5f;
    Vector2 move;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float Jumpforce;

    private bool DoubleJump;
    
    private bool grounded;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (grounded && !Input.GetButton("Jump"))
        {
            DoubleJump = false;
        }

        if(Input.GetButtonDown("Jump"))
        {
            if (grounded || DoubleJump)
            {
                rb.AddForce(new Vector2(rb.velocity.x, Jumpforce));

                DoubleJump = !DoubleJump;
            }
            
        }

        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(move.x * Speed * Time.deltaTime, rb.velocity.y);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground")) 
        {
            grounded = true;

        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = false;

        }
    }
}
