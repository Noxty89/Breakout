using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class muestraEventos : MonoBehaviour
{
    public UnityEvent MiEventoUnity;
    public EventHandler OnSpacePressed;
    // Start is called before the first frame update
    void Start()
    {
        OnSpacePressed += EventoEscuchado;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            OnSpacePressed?.Invoke(this, EventArgs.Empty);
            MiEventoUnity.Invoke();
        }
        
    }
    public void EventoEscuchado(object sender, EventArgs e)
    {
        Debug.Log("El Evento se Escucho Correctamente");
    }
    public void EventoUnityDisparado()
    {
        Debug.Log("El Evento Unity Se A Disparado Correctamente");    
    }
}
