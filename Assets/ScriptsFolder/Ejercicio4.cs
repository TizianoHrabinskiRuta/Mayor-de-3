﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

   public int? num1;
   public int? num2;


    // Start is called before the first frame update
    void Start()
    {
        if (num1 == null || num2 == null) return;

        Debug.Log("La  suma entre " + num1 + " y " + num2 + " da como resultado" + num1 + num2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}