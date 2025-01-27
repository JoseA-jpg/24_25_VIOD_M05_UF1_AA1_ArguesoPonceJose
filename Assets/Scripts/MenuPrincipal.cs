using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Multijugador()
    {
        Debug.Log("Multijugador");
        SceneManager.LoadScene("Multijugador");
    }
    public void UnJugador()
    {
        Debug.Log("Un Jugador");
        SceneManager.LoadScene("UnJugador");
    }
    public void Salir()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}
