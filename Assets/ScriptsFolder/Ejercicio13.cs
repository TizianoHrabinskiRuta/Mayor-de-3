using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{

    public int HorasTrabajadas;
    int Const = 16;

    // Start is called before the first frame update
    void Start()
    {
        if( HorasTrabajadas <= 40)
        {
            Debug.Log("Tendria que cobrar: " + HorasTrabajadas * Const);
            return;
        }

        Debug.Log("Tendria que cobrar: " + ((HorasTrabajadas - 40) * 20) + (HorasTrabajadas * Const));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
