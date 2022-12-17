using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool _disableMovement = false;

    // Our components
    Rigidbody2D _rb;  // Create the container for our Rigidbody2D

    // Our fields related to movement
    float _moveHorizontal;  // Get horizontal input
    float _moveSpeed = 60f;  // Out movespeed


    void Start()
    {
        // Assign the Rigidbody2D to our container
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        // Assign the player input
        _moveHorizontal = Input.GetAxisRaw("Horizontal");
    }


    void FixedUpdate()
    {
        if (!_disableMovement)
        {
            MovePlayer();
        }
    }

    // Create the  method for player movement
    void MovePlayer()
    {
        if (_moveHorizontal != 0)  // Check for player input
        {
            _rb.AddForce(new Vector2(_moveHorizontal * _moveSpeed, 0f));
        }
    }

}