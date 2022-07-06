using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Opciones", menuName = "Herramientas/Opciones", order = 1)]
public class Opciones : PuntajePersistente
{
    public float VelocidadBola = 30;
    public dificultad NivelDificultad = dificultad.facil;

    public enum dificultad
    {
        facil,
        normal,
        dificil
    }
    public void CambiardeVelocidad(float nuevaVelocidad)
    {
        VelocidadBola = nuevaVelocidad;

    }
    public void CambiarDificultad(int nuevaDificultad)
    {
        NivelDificultad = (dificultad)nuevaDificultad;
    }
}