using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    List<string> _numbers = new List<string>();
    /*
       This is how we can instantiate a list...
       This is not actually a datatype. This is the class that exits someware inside System.Collections.Generic...
    */


    // Start is called before the first frame update
    void Start()
    {
        _numbers.Add("Elon");   //  --0
        _numbers.Add("Mark");   //  --1
        _numbers.Add("Sundar");   //  --2
        _numbers.Add("Albert");   //  --3

        _numbers.Remove("Elon");
        /*
           This removes Elon and now the 0 index of list named _numbers will become Mark...
        */

        _numbers.Insert(1, "Arjun");
        /*
           This will insert Arjun at 1 index i.e. _numbers.Remove("Elon"); will remove Elon, then 0 index will be
           Mark then 1 index will be Arjun as we are inserting at 1, 2 index will be Sundar and so on...
        */

        Debug.Log(_numbers[0]);
        /*
           This grabs the 0 index of list named _numbers i.e Elon...
        */

        Debug.Log(_numbers[1]);
        /*
           This grabs the 1 index of list named _numbers i.e Mark...
        */

        Debug.Log(_numbers[2]);
        /*
           This grabs the 2 index of list named _numbers i.e Mark...
        */

        // Debug.Log(_numbers[3]);
        /*
           This grabs the 3 index of list named _numbers i.e Mark...
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
