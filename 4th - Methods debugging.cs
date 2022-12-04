using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
private int _playerHealth = 100;

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


    private void Start()  // It is private method called Start and this is builtin method inside MonoBehaviour...
    {
        TakeDamage(50);

        /* 
        * At first this 50 will be assigned to void TakeDamage(.here.) then in void TakeDamage(int damage)
        * PlayerHealth -= damage;  --> Here the value entered in TakeDamage(.here.) assigns in value of damage...
        * 
        * So PlayerHealth = 100 - 50 i.e. 50...
        */

        Debug.Log(PlayerHealth);
    }

    void TakeDamage(int damage)

        /* 
         * At first 
         */

        /* 
         * () shows that TakeDamage is a method not a property...
         * 
         * It Doesnot return data but it does something...
         */
    {
        PlayerHealth -= damage; // PlayerHealth = PlayerHealth - damage;
    }

    int ShowDamage()  // Returns data
    {
        PlayerHealth -= 10;  // 10 or integer cuz ShowDamage is a method that returns integer...
        return PlayerHealth;
    }
    
    Boolean ShowDaamage()
    {
        return true;
    }

}
