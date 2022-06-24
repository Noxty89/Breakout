using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public Transform TransformPuntajeAlto;
    public Transform TransformPuntajeActual;
    public TMP_Text TextoPuntajeAlto;
    public TMP_Text TextoActual;
    public PuntajeAlto PuntajeAltoSO;

  





    // Start is called before the first frame update
    void Start()
    {
        PuntajeAltoSO.Cargar();
        TransformPuntajeActual = GameObject.Find("PuntajeActual").transform;
        TransformPuntajeAlto = GameObject.Find("PuntajeAlto").transform;
        TextoActual = TransformPuntajeActual.GetComponent<TMP_Text>();
        TextoPuntajeAlto = TransformPuntajeAlto.GetComponent<TMP_Text>();

        //if (PlayerPrefs.HasKey("puntajeAlto"))
        //{
        //PuntajeAlto = PlayerPrefs.GetInt("PuntajeAlto");

        //}
        TextoPuntajeAlto.text = $"PuntajeAlto: {PuntajeAltoSO.puntajeAlto}";
        PuntajeAltoSO.puntaje = 0;


    }
    private void FixedUpdate()
    {
        PuntajeAltoSO.puntaje += 50;
    }

    // Update is called once per frame
    void Update()
    {
      
        TextoActual.text = $"PuntajeActual: {PuntajeAltoSO.puntaje}";
        if (PuntajeAltoSO.puntaje > PuntajeAltoSO.puntajeAlto)
        {
            PuntajeAltoSO.puntajeAlto = PuntajeAltoSO.puntaje;
            TextoPuntajeAlto.text = $"PuntajeAlto: {PuntajeAltoSO.puntajeAlto}";
            PuntajeAltoSO.Guardar();
            //PlayerPrefs.SetInt("PuntajeAlto", Puntos);

        }


    }
}
