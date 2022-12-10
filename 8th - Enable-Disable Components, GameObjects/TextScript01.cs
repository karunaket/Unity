using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript01 : MonoBehaviour
{
    BoxCollider2D _col;

    // Start is called before the first frame update
    void Start()
    {
        _col = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _col.enabled = false;  // _col.enabled = !_col.enabled;
        }
    }
}
