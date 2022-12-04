using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour

    /* 
    Instead of creating below field and property, we can create auto-property...
    */
{
    // Creating auto-property...

    // public PlayerHealth { get; set; }

    private int _playerHealth = 100;  // field

    public int PlayerHealth  /* when there is something inside the field then it is said
                            property...*/
    {
        get  // The get method returns the value of the variable...
        {
            return _playerHealth;
        }

        set  /* The set method assigns a value to the variable. The value keyword
                represents the value we assign to the property...*/
        {
            _playerHealth = value;
        }

        /* 
        Now the value will be taken from the property not the field...
        
        At first it goes inside the property named PlayerHealth and grabs the set method
        then uses to set method whatever I have wrote inside the set method inorder to assign 
        the value to player health...

        Then it grabs the get method and uses the method insted...

        This is the way to change or grab the data from our field without having directly
        refers to the field...
        */


        /* 
        we can add additional codes inside the get or set methods inorder to change the
        outcome when we use get or set method...
If we remove the set method then we cannot assign the value of PlayerHealth 

        private void Start()
        {
            from here
        }
        */
    }

    public string DisplayHealthPercentage
        
        /*
        Here we have removed set method so here we only show the value we cannot assign
        the value...
         */
    {
        get
        {
            string health = _playerHealth.ToString() + "%";
            /* 
            _playerHealth is integer datatype so to convert it to string .ToString() is used
        --> + means add another string to it...and another string is "%".
            */

            return health;
        }
    }

    private void Start()
    {
        Debug.Log(DisplayHealthPercentage);
    }

}
