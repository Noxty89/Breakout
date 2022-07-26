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

    public void CambiarResistencia(int NuevaResistencia)
    {
        ResistenciaBloques = (int)(dificultad)NuevaResistencia;

        if (facil)
        {
            ResistenciaBloques = NuevaResistencia + 0;
        }
        if (normal)
        {
            ResistenciaBloques = NuevaResistencia + 3;
        }
        if (dificil)
        {
            ResistenciaBloques = NuevaResistencia + 5;
        }
            
                  
    }

}