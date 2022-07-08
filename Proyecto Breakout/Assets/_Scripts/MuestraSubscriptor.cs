using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuestraSubscriptor : MonoBehaviour
{
    muestraEventos subscriptor;
    // Start is called before the first frame update
    void Start()
    {
        subscriptor = GetComponent<muestraEventos>();
        subscriptor.OnSpacePressed += MensajeEscuchadoPorElSubscriptor;

    }

   private void MensajeEscuchadoPorElSubscriptor(object sender, EventArgs e)
    {
        Debug.Log("El Evento A sido Escuchado Desde Otra Clase");
        subscriptor.OnSpacePressed -= MensajeEscuchadoPorElSubscriptor;
    }
}
