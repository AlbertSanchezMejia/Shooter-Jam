using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{

    public float currentVolume = 1f;

    public void Start()
    {
        
    }

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

    public void Rerty_main ()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

    public void Salir()
    {
        Application.Quit();
    }

}
