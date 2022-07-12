using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorVidas : MonoBehaviour
{
    [HideInInspector] public List<GameObject> vidas;
    public GameObject bolaPrefab;
    private Bola BolaScript;
    public GameObject MenuFinDelJuego;
    // Start is called before the first frame update
    void Start()
    {
        Transform[] hijos = GetComponentsInChildren<Transform>();
        foreach(Transform hijo in hijos)
        {
            vidas.Add(hijo.gameObject);
        }

    }

    public void EliminarVida()
    {
        var ObjetoAEliminar = vidas[vidas.Count - 1];
        Destroy(ObjetoAEliminar);
        vidas.RemoveAt(vidas.Count - 1);
        if(vidas.Count <= 0)
        {
            MenuFinDelJuego.SetActive(true);
            return;
        }
        var bola = Instantiate(bolaPrefab) as GameObject;
        BolaScript = bola.GetComponent<Bola>();
        BolaScript.BolaDestruida.AddListener(this.EliminarVida);
        Debug.Log($"Vidas Restantes: {vidas.Count} ");

    }

}
