using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    static public int vi_nivelDesbloqueados;
    public int vi_nivelActual;
    public Button[] vi_botonesMenu;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            ActualizarBotones();
        }
    }
    public void reiniciarNivel()
    {
        SceneManager.LoadScene("escena2");
    }
    public void mayorDificultad()
    {
        SceneManager.LoadScene("escena3");
    }
    // Update is called once per frame
    
    public void salir()
    {
        Application.Quit();
    }
   
    public void ActualizarBotones()

    {
        for (int i = 0; i < (vi_nivelDesbloqueados + 1); i++)
        {
            vi_botonesMenu[i].interactable = true;
        }
    }
}
