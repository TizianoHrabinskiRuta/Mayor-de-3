using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("this is a test of the link between VS and Unity Engine");

         int num1 = 0;

        num1 += 2;
        Debug.Log(num1.ToString());
        Debug.Log("\n" + num1 * num1);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
