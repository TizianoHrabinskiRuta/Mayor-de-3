using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{


    public int num1;
    public int num2;
    public int num3;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2 && num1 == num3 && num3 == num2)
        {
            Debug.Log("Los numeros son iguales");
            return;
        }

        int[] SortingArray = new int[3];
        int MaxValue = 0;
        int IndexOfMaxValueSearcher = 0;
        int FoundIndexOfMaxValue = 0;
             

        SortingArray[0] = num1;
        SortingArray[1] = num2;
        SortingArray[2] = num3;

        foreach(int i in SortingArray)
        {
            if (i > MaxValue)
            {
                MaxValue = i;
                FoundIndexOfMaxValue = IndexOfMaxValueSearcher;
            }
            IndexOfMaxValueSearcher++;
        }

        Debug.Log("El numero mayor era " + SortingArray[FoundIndexOfMaxValue]);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
