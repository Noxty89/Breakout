using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Agua : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        Resistencia = 1;

        //pero al destruitr el bloque se realentiza la bola y cambia su direccion aleatoriamente
    }
   
}
