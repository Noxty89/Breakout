using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBordes : MonoBehaviour
{
    [Header("Configurar en el Edito")]
    public float radio = 1f;
    public bool MantenerEnPantalla = false;

    [Header("Configuraciones Dinamicas")]
    public bool EstaEnPantalla = true;
    public float AnchoCamara;
    public float AltoCamara;
    public bool SalioDerecha, SalioIzquierda, SalioArriba, SalioAbajo;

    public void Awake()
    {
        AltoCamara = Camera.main.orthographicSize;
        AnchoCamara = Camera.main.aspect * AltoCamara;
    }
    // Update is called once per frame
    void lateUpdate()
    {
        Vector3 pos = transform.position;
        EstaEnPantalla = true;
        SalioAbajo = SalioArriba = SalioIzquierda = SalioDerecha = false;

        if (pos.x > AnchoCamara - 2)
        {
            pos.x = AnchoCamara - 2;
            SalioDerecha = true;
        }
        if (pos.x < -AnchoCamara + 2)
        {
            pos.x = -AnchoCamara + 2;
            SalioIzquierda = true;
        }
        if (pos.y > AltoCamara - 2)
        {
            pos.y = AnchoCamara - 2;
            SalioArriba = true;
        }
        if (pos.y < -AltoCamara + 2)
        {
            pos.y = -AltoCamara + 2;
           
        }
        EstaEnPantalla = !(SalioAbajo || SalioArriba || SalioDerecha || SalioIzquierda);
        if(MantenerEnPantalla && EstaEnPantalla)
        {
            transform.position = pos;
            EstaEnPantalla = true;
        }
    }
    private void OnDrawGizmos()
    {
        if (!Application.isPlaying) return;
        Vector3 tamanoborde = new Vector3(AnchoCamara * 2, AltoCamara * 2, 0.1f);
        Gizmos.DrawWireCube(Vector3.zero, tamanoborde);
    }
}
