using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int puntA;
    public TMP_Text puntAtext;
    public int puntB;
    public TMP_Text puntBtext;
    private void Update()
    {
        puntAtext.text = puntA.ToString();
        puntBtext.text = puntB.ToString();
        if(puntA > 9 || puntB > 9)
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
    }
}
