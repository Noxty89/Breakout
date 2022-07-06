using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownDificultad : MonoBehaviour
{
    public Opciones opciones;
    private Dropdown dificultad;

    private void Start()
    {
        dificultad = GetComponent<Dropdown>();
        dificultad.onValueChanged.AddListener(delegate { opciones.CambiarDificultad(dificultad.value); });
    }
}
