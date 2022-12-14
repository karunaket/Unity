using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour
{
    [SerializeField] Transform target;
    Vector2 lastRotation;

    void Update()
    {
        Vector2 direction = target.position - transform.position;

        /* 
        This will say the gameObject at which it is attached to to rotate at a certain direction based on the offset...
        */


        if (lastRotation != direction)
        {

            transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
            // new Vector3(0, 1, 0)  ===  Vector3.up/down/ left/right/ back/forward


            // Rotates the gameObject from a certain location to a new location...

            Debug.Log("test");

        }

        lastRotation = direction;
    }
}
