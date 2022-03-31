using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    public int Dice1;
    public int Dice2;
    public int Dice3;


    // Start is called before the first frame update
    void Start()
    {
        int IndexFinder = 0;
        int[] SixFinder = new int[4];
        bool[] IgnoreMarker = new bool[4];
        int SumOfDice = 0;

        foreach (int i in SixFinder)
        {
            if(i != 6)
            {
                IgnoreMarker[IndexFinder] = true;
            }
            else
            {
                IgnoreMarker[IndexFinder] = false;
            }
            IndexFinder++;
        }

        IndexFinder = 0;

        foreach (bool i in IgnoreMarker)
        {
            if (!i)
            {
                SumOfDice += SixFinder[IndexFinder];
            }
            IndexFinder++;
        }

        

        switch (SumOfDice)
        {
            case 18:
                Debug.Log("Excelente");
                break;

            case 12:
                Debug.Log("Muy bien");
                break;

            case 6:
                Debug.Log("Regular");
                break;

            default:
                Debug.Log("Insuficiente");
                break;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
