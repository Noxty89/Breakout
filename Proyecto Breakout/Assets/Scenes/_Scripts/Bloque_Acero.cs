using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Acero : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        //este bloque lo intente hacer invencible esta es la forma correcta?
        int a = Resistencia + 5;
        Resistencia = 10;
        if (Resistencia <= 4)
        {
            Resistencia = a;
        }
    }

}
