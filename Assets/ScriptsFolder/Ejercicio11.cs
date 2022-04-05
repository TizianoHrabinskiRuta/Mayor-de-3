using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{

    public string Fecha;
    public string Comprador;
    public string Producto;
    public string Cantidad;
    public string Precio;
    



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Fecha de compra: " + Fecha + " \n Nombre del Comprador: " + Comprador + " \n Producto Solicitado: " + Producto + " \n Cantidad Solicitada: " + Cantidad + " \n Precio unitario: " + Precio + " \n Total a pagar: " + Convert.ToInt32(Precio) * Convert.ToInt32(Cantidad));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
