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
        }
        
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(new Vector3(0f, 0f, _rotateSpeed) * Time.deltaTime, Space.Self);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(new Vector3(0f, 0f, -_rotateSpeed) * Time.deltaTime, Space.Self);
        }
    }
}
