using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;



public class Bloque : MonoBehaviour
{
    public int Resistencia = 2;
    public UnityEvent AumentarPuntaje;
    public Opciones opciones;


    public void Awake()
    {
        if(opciones.NivelDificultad == Opciones.dificultad.facil)
        {
            Resistencia = Resistencia - 1;
        }
        if (opciones.NivelDificultad == Opciones.dificultad.normal)
        {
            Resistencia = Resistencia +1;
        }
        if (opciones.NivelDificultad == Opciones.dificultad.dificil)
        {
            Resistencia = Resistencia - +3;
        }


    }



    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bola")
        {
            RebotarBola(collision);
        }
    }

    public virtual void RebotarBola(Collision collision)
    {
        Vector3 direccion = collision.contacts[0].point - transform.position;
        direccion = direccion.normalized;
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        Resistencia--;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Resistencia <= 0)
        {
            AumentarPuntaje.Invoke();
            Destroy(this.gameObject);
        }
    }
    public virtual void RebotarBola()
    {

    }

    


}
