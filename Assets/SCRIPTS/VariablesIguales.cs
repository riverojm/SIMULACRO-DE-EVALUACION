﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesIguales : MonoBehaviour
{
    // 1. Crear un programa que permita ingresar por inspector dos valores enteros y responda si son iguales o no lo son.
    // 1. Crear las variables necesarias para ingresar por inspector el precio de 3 productos y un monto de dinero disponible
    //    Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuanto dinero sobra o falta.
    // Start is called before the first frame update
    public int numero1;
    public int numero2;
    void Start()
    {
        if (numero1 == numero2)
        {
            Debug.Log("Los numeros son iguales"); 
        }
        else
        {
            Debug.Log("Los numeros no son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
