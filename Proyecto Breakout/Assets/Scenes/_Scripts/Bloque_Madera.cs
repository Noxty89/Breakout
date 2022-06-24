using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Madera : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        Resistencia = 2;
    }

    // Update is called once per frame
    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}
