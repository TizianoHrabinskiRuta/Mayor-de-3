using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{

    public float MP1;
    public float MP2;
    public float MP3;
    float Total;
    float PP1;
    float PP2;
    float PP3;

    // Start is called before the first frame update
    void Start()
    {
        Total = MP1 + MP2 + MP3;

        //PP1 = (Total * MP1) / 100; falta matematica que funciona xd
        //PP2 = (Total * MP2) / 100;
        //PP3 = (Total * MP3) / 100;

        Debug.Log("La persona 1 aporto " + MP1 + ", el cual representa el " + PP1 + "% de " + Total);
        Debug.Log("La persona 2 aporto " + MP2 + ", el cual representa el " + PP2 + "% de " + Total);
        Debug.Log("La persona 1 aporto " + MP3 + ", el cual representa el " + PP3 + "% de " + Total);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
