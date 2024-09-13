using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuBotonesN1 : MonoBehaviour {
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menubotones;

    public void Pausa(){
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menubotones.SetActive(true);

    }

    public void Reanudar(){
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menubotones.SetActive(false);

    }

    public void Reiniciar(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerPrefs.DeleteKey("VariablePuntos");
        
    }

    public void Cerrar(){
        Debug.Log("Cerrando juego");
        Application.Quit();
        
    }

    public void VolverMenu(){
        Debug.Log("Regresar al menu");
        PlayerPrefs.DeleteKey("VariablePuntos");
        SceneManager.LoadScene(0);
        
    }

    public void VolverMenuConDatos(){
        SceneManager.LoadScene(0);
        
    }
}