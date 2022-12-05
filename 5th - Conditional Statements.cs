using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private int _playerHealth = 100;
    private int _playerShield = 50;

    public int PlayerHealth
    {
        get
        {
            return _playerHealth;
        }

        set
        {
            _playerHealth = value;
        }
    }
    public int PlayerShield
    {
        get
        {
            return _playerShield;
        }

        set
        {
            _playerShield = value;
        }
    }


    private void Start()
    {
        Debug.Log("You took " + DamageTaken(100) + " damage!");
    }

    int DamageTaken(int damage)
    {
        int damageTaken;


        if (damage < PlayerShield)
        {
            Debug.Log("Shield not destroyed!");
            damageTaken = 0;
        }

        else if (damage == PlayerShield)
        {
            Debug.Log("Shield destroyed!");
            damageTaken = 0;
        }

        else
        {
            Debug.Log("Shield destroyed and damage taken!");
            damageTaken = damage - PlayerShield;
        }
      

      /*  if(damage < PlayerShield || damage == PlayerShield)
        {
            Debug.Log("Shield not destroyed!");
            damageTaken = 0;
        }
      */


        return damageTaken;
    }

}