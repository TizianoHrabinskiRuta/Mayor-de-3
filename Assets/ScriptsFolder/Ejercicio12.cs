using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    public int Dice1;
    public int Dice2;
    public int Dice3;


    // Start is called before the first frame update
    void Start()
    {
        int SumOfDice = Dice1 + Dice2 + Dice3;

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
