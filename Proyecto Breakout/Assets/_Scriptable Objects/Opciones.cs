using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Opciones", menuName = "tools/Opciones", order = 1)]
public class Opciones : PuntajePersistente
{
    public float VelocidadBola = 30;
    public dificultad NivelDificultad = dificultad.facil;
    public int ResistenciaBloques = 5;
    bool facil, normal, dificil;
    internal object onValueChanged;
    public int nuevaDificultad;

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

        if (NivelDificultad == dificultad.facil)
        {
            ResistenciaBloques = ResistenciaBloques + -1;
        }
        if (NivelDificultad == dificultad.normal)
        {
            ResistenciaBloques = ResistenciaBloques + 0;
        }
        if (NivelDificultad == dificultad.dificil)
        {
            ResistenciaBloques = ResistenciaBloques + 0;
        }

    }


       
}