using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    
    public void PlayGame ()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
    public void Mostrar_creditos ()
    {
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }

    public void Mostrar_opciones ()
    {
        SceneManager.LoadScene("Options", LoadSceneMode.Single);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
