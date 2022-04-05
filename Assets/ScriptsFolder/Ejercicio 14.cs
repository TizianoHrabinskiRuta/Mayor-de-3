using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio14 : MonoBehaviour
{


    public char Operator;
    public int Num1;
    public int Num2;
    // Start is called before the first frame update
    void Start()
    {

        switch (Operator)
        {
            case 's':
                Debug.Log(Num1 + Num2);
                break;

            case 'S':
                Debug.Log(Num1 + Num2);
                break;

            case 'r':
                Debug.Log(Num1 - Num2);
                break;

            case 'R':
                Debug.Log(Num1 - Num2);
                break;

            case 'p':
                Debug.Log(Num1 * Num2);
                break;

            case 'P':
                Debug.Log(Num1 * Num2);
                break;

            case 'd':
                Debug.Log(Num1 / Num2);
                break;

            case 'D':
                Debug.Log(Num1 / Num2);
                break;

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
