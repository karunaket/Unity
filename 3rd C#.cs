using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private int _playerHealth = 100;  // field

    public int PlayerHealth  /* when there is something inside the field then it is said
                              property...*/
    {
        get  // The get method returns the value of the variable name...
        {
            return _playerHealth;
        }

        set  /* The set method assigns a value to the name variable. The value keyword
                represents the value we assign to the property...*/
        {
            _playerHealth = value;
        }
    }

    private void Start()
    {
        PlayerHealth = 50;

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
        */
    }

}
