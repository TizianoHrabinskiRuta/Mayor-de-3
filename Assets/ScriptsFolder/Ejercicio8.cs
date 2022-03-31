using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{

    public int DiaIngresado;
    // Start is called before the first frame update
    void Start()
    {
        switch (DiaIngresado)
        {

            case 1:
                Debug.Log("El dia es Domingo");
                break;

            case 2:
                Debug.Log("El dia es Lunes ");
                break;

            case 3:
                Debug.Log("El dia es Martes");
                break;

            case 4:
                Debug.Log("El dia es Miercoles ");
                break;

            case 5:
                Debug.Log("El dia es Jueves ");
                break;

            case 6:
                Debug.Log("El dia es Viernes ");
                break;

            case 7:
                Debug.Log("El dia es Sabado");
                break;

            default:
                Debug.Log("El dia ingresado no es valido ");
                break;

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
