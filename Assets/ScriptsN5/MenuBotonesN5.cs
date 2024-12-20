using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuBotonesN5 : MonoBehaviour {
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
        //Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerPrefs.DeleteKey("VariablePuntosN5");
        
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

    /*void Cronometro(){

        if (!tiempoDetenido){
            tiempo -= Time.deltaTime;
        }


        tiempoMinutos = Mathf.FloorToInt(tiempo / 60);
        tiempoSegundos = Mathf.FloorToInt(tiempo % 60);

        textoCrono.text = string.Format("{0:00}:{1:00}", tiempoMinutos, tiempoSegundos);

        if (tiempo <= 0){
            tiempoDetenido=true;
            tiempo=0;
            Debug.Log("Tu tiempo se acabo");
            ImagenTT.SetActive(true);
            BotonTT.SetActive(true);
        }
    }

    void Update(){
        Cronometro();
    }

    void Start(){
        Time.timeScale = 1f;
    }*/
}