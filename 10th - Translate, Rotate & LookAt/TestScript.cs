using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    float _moveSpeed = 7f;
    float _rotateSpeed = 200f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(new Vector2(0f, _moveSpeed) * Time.deltaTime, Space.Self);

            /* If we don't use Time.deltaTime then the gameObject will move so fast because of higher framerate...
            
            If we don't use Space.Self then as a default it is going to move around the local space of the gameObject...
            Space.Self  -->  It will help gameObject to move all around in the space...
            */
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(new Vector3(0f, 0f, _rotateSpeed) * Time.deltaTime, Space.Self);

            // Rotate cuz now we need not to move the object...we need to rotate...
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(new Vector3(0f, 0f, -_rotateSpeed) * Time.deltaTime, Space.Self);
        }
    }
}
