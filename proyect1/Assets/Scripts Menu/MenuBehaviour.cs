using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour
{
    public void partidaNueva()
    {
        SceneManager.LoadScene("Partida Nueva Menu");
    }
    public void regresarMenuInicialDesdePartidaNueva()
    {
        SceneManager.LoadScene("Menu Inicial");
    }
    public void configuracionesScene()
    {
        SceneManager.LoadScene("Configuraciones");
    }

    public void salirButton()
    {
        Application.Quit();
    }
}
