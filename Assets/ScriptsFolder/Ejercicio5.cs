using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 == 0 || num2 == 0)
        {
            Debug.Log("No se puede dividir por 0");
            return;
        }

        Debug.Log(num1 + "/ " +num2 + " = " + num1 / num2 );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
