using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript02 : MonoBehaviour
{
    [SerializeField] GameObject _squareParent;
    [SerializeField] GameObject _square;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            // Debug.Log(_squareParent.activeSelf);
            _squareParent.SetActive(false);
            Debug.Log(_square.activeInHierarchy);
        }
    }
}
