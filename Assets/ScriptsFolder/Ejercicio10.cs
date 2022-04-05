using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio10 : MonoBehaviour
{

     int HORA_APERTURA = 10;
     int HORA_CIERRE = 18;
     bool estaAbierto;

    public int HoraActual;


    // Start is called before the first frame update
    void Start()
    {

        if(HoraActual < HORA_APERTURA)
        {
            estaAbierto = false;
            return;
        }

        if(HoraActual > HORA_APERTURA && HoraActual < HORA_CIERRE)
        {
            estaAbierto = true;
            return;
        }

        if(HoraActual > HORA_CIERRE)
        {
            estaAbierto = false;
            return;
        }

        Debug.Log("Ingreso una hora Incorrecta");
    }
        

    // Update is called once per frame
    void Update()
    {
        
    }
}
