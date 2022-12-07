using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] GameObject _item;

    // Start is called before the first frame update
    void Start()
    {
        int itemCount = 5;

        // while Loop
        while (itemCount > 0)
        {
            _spawnItem();
            itemCount--;
        }

        // do-while Loop
        do
        {
            _spawnItem();
            itemCount--;
        }
        while (itemCount > 0);

        // for Loop
        for (int i = 5; i > 0; i--)
        {
            _spawnItem();
            itemCount--;
        }

    }

    // Update is called once per frame
    void _spawnItem()
    {
        Instantiate(_item, new Vector2(Random.Range(6.5f, -6.5f), Random.Range(3.5f, -3.5f)), Quaternion.identity);
    }
}
