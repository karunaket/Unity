using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour

{
    private Rigidbody2D _rb;  // private Rigidbody2D _rb; is the field and _rb is the empty container that needs to contain Rigidbody2D components...

    [SerializeField] private int _playerHealth = 100;

    // if we add [SerializeField] at front then we can access it in Inspector even it is private...

    /* when private is used then variable name starts with_(underscore) and public starts with capital letter...If we don't mention anything like private or public then
    itself it creates the private variable so Default is private...*/

    public float _playerSpeed = 4.6f;

    /* if this is public then we can change the value of _playerSpeed even from the inspector */

    private bool _isGrounded = true;
    private string _playerName = "Krossing";
    private Vector2 _playerPosition = new Vector2(-5f, 0f);

    /* Vector3 is used in 3D Games and in vector2 there will only be x and y axis(not z-axis) */


    private void Start()
    {
        _rb = gameObject.AddComponent<Rigidbody2D>();
        /* Assigning the actual Rigidbody2D component here..then we can change stuffs inside it...*/
        _rb.gravityScale = 0;  // we can also access Rigidbody2D component from here too...
    }

}
