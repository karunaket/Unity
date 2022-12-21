using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // Example - 1
    int _number = 12;
    int[] _numberArray = new int[4];  // Declaring Array

    // Example - 2
    string[] _names = { "Elon", "Mark", "Sundar", "Albert" };  // Assigning values in array

    // Example - 3
    public GameObject[] _players; // Public // Array of GameObject type
    // [SerializeField] GameObject[] _players;  // Private


    // Start is called before the first frame update
    void Start()
    {
        _numberArray[0] = 10;
        _numberArray[1] = 23;
        _numberArray[2] = 53;
        _numberArray[3] = 15;

        //Debug.Log(_numberArray[0]);

        _players = GameObject.FindGameObjectsWithTag("Player");
        /* 
           The GameObject having Tag named Player will get assigned to GameObject array named _players...
        */
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _players = GameObject.FindGameObjectsWithTag("Enemy");
        }
        /*
           If space key is pressed then it is going to take _players array and is going to reassign with all the 
           different GameObjects that has a tag as Enemy insted...
        */
    }
}
