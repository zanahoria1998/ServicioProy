using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuBotonesN1 : MonoBehaviour {
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menubotones;

    [SerializeField] private GameObject botonSi;
    [SerializeField] private GameObject botonNo;
    [SerializeField] private GameObject ConfirSalir;

    public GameObject sonido;
    public GameObject sonidoMute;
    
    /*[SerializeField] TextMeshProUGUI textoCrono;
    [SerializeField] private float tiempo;
    public GameObject BotonTT;
    public GameObject ImagenTT;

    bool tiempoDetenido;

    private int tiempoMinutos, tiempoSegundos;*/

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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerPrefs.DeleteKey("VariablePuntos");
        /*Time.timeScale = 1f;
        Debug.Log("Reinicia reloj");*/
        
    }


    public void CerrarNivel(){
        
        ConfirSalir.SetActive(true);
        
    }

    public void ButtonSi(){
        Debug.Log("BorrarPuntos");
        PlayerPrefs.DeleteKey("VariablePuntos");
        Debug.Log("Cerrando juego");
        Application.Quit();
    }

    public void ButtonNo(){
        ConfirSalir.SetActive(false);
    }

    public void VolverMenu(){
        SceneManager.LoadScene(0);
        
    }

    public void PausarSonido(){
        ScriptAudio.Pausar();
        sonidoMute.SetActive(true);
        sonido.SetActive(false);
    }

    public void DespausarSonido(){
        ScriptAudio.Despause();
        sonidoMute.SetActive(false);
        sonido.SetActive(true);
    }
}