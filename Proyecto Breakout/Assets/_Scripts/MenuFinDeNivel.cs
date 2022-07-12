using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFinDeNivel : MonoBehaviour
{
    public void SiguienteNivel()
    {
        var SiguienteNivel = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings < SiguienteNivel)
        {
            SceneManager.LoadScene(SiguienteNivel);
        }
        else
        {
            CargarMenuPrincipal();
        }
    }
    public void CargarMenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    public void ReintentarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
