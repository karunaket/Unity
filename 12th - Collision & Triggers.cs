using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Move using Rigidbody
    Rigidbody2D _rb;  // Create the container for our Rigidbody2D

    // Our fields related to movement
    float _moveHorizontal;  // Get horizontal input
    float _moveSpeed = 10f;  // Out movespeed
    Vector2 _currentVelocity;  // Our current Velocity

    // Trigger example
    bool _canInteract = false;


    void Start()
    {
        // Assign the Rigidbody2D to our container
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }
    

    void Update()
    {
        // Assign the player input
        _moveHorizontal = Input.GetAxisRaw("Horizontal");

        // Assign the current speed/velocity
        _currentVelocity = new Vector2(_moveHorizontal, 0f) * _moveSpeed;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (_canInteract == true)
            {
                Debug.Log("Turn on light switch!");
            }
        }
    }


    void FixedUpdate()
    {
        MovePlayer();
    }

    // Create the  method for player movement
    void MovePlayer()
    {
        if (_moveHorizontal != 0)  // Check for player input
        {
            _rb.velocity = _currentVelocity; // Set the player movement to the current velocity
        }

        else  // If standing still
        {
            // Set player movement to zero
            _currentVelocity = new Vector2(0f, 0f);
            _rb.velocity = _currentVelocity;
        }
    }

    /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            // disables/vanishes the ball when player touches the ball...

            // Debug.Log("Enter");
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("Exit");
        }
    } */


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LightSwitch")
        {
            _canInteract = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LightSwitch")
        {
            _canInteract = false;
        }
    }
}