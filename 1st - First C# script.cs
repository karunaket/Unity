using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 *  System.Collections;
 *  System.Collections.Generic;
 *  UnityEngine;               ---> These are called namespaces. Simply namespace is the 
 *                                  collection of classes... We can say them library
 *                                  also...  
 */

public class Test : MonoBehaviour

    /* 
     * MonoBehaviour is  the class which is inside the namespace named UnityEngine and now
     * we can access void Start() and void Update() which is also simply the syntax of 
     * class MonoBehaviour...
     */

{

    Rigidbody2D _rb;

    float _walkspeed;
    float _inputHorizontal;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();

        _walkspeed = 5.5f;
    }

    // Update is called once per frame
    void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");

        if(_inputHorizontal != 0)
        {
            _rb.AddForce(new Vector2(_inputHorizontal * _walkspeed, 0f));
        }
    }
}
