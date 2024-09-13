using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuBotonesN5 : MonoBehaviour {
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
        PlayerPrefs.DeleteKey("VariablePuntosN5");
        
    }

    public void Cerrar(){
        Debug.Log("Cerrando juego");
        Application.Quit();
        
    }

    public void VolverMenu(){
        Debug.Log("Regresar al menu");
        PlayerPrefs.DeleteKey("VariablePuntosN5");
        SceneManager.LoadScene(0);
        
    }
}