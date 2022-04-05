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
       
        int[] SixFinder = new int[4];
        int SumOfDice = 0;

        SixFinder[0] = Dice1;
        SixFinder[1] = Dice2;
        SixFinder[2] = Dice3;

        foreach (int i in SixFinder)
        {
          if (i == 6)
            {
                SumOfDice += i;
            }
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
