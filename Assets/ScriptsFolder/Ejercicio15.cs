using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio15 : MonoBehaviour
{


    public int Input;
    bool EstaEnA;
    bool EstaEnB;
    bool EstaEnAmbos;
    bool NoEstaEnNingunos;
    // Start is called before the first frame update
    void Start()
    {
        if(Input % 2 != 0 && Input < 10)
        {
            EstaEnAmbos = true;
            break;
        }
        else if(Input % 2 == 0 && Input < 10)
        {
            EstaEnB = true;
            break;
        }
        else if(Input % 2 !=0 && Input >= 10)
        {
            EstaEnA = true;
            break;
        }
        else if(Input % 2 == 0 && Input >= 10)
        {
            NoEstaEnNingunos = true;
            break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
