using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculoDinero : MonoBehaviour
{
    // 1. Crear las variables necesarias para ingresar por inspector el precio de 3 productos y un monto de dinero disponible
    //    Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuanto dinero sobra o falta.
    // Start is called before the first frame update
    public float PrecioProd1;
    public float PrecioProd2;
    public float PrecioProd3;
    float Dinerototal;
    float Resto;
    public float DineroDisponible;
    void Start()
    {
        Dinerototal = PrecioProd3 + PrecioProd2 + PrecioProd1;
        if (Dinerototal > DineroDisponible)
        {
            Resto = Dinerototal - DineroDisponible;
            Debug.Log("Te sobran $"+Resto+"");
        }
        if (Dinerototal < DineroDisponible)
        {
            Resto = DineroDisponible - Dinerototal;
            Debug.Log("Te faltan $"+Resto+"");
        }
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
