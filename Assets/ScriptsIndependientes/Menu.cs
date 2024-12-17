using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject botonSi;
    [SerializeField] private GameObject botonNo;
    [SerializeField] private GameObject ConfirSalir;
    public Button So;
    public Button Mal;
    public Button SeguWiFi;
    public Button Contra;
    public Button TeleConf;
    public Button SegNube;
    public Button NavSeg;
    public Button IngSocial;
    public Button CopSeg;
    private int N1;
    private int N2;
    private int N3;
    private int N4;
    private int N5;
    private int N6;
    private int N7;
    private int N8;
    private int N9;

    //public Textos textos;//Liga el script de Textos a este script
    //public ControlDialogo punto;

    void Start(){

        //FindObjectOfType<ControlDialogoMenu>().ActivarCartel(textos);
        PlayerPrefs.DeleteAll();
        N1 = PlayerPrefs.GetInt("VariablePuntos", 0);
        N2 = PlayerPrefs.GetInt("VariablePuntosN2", 0);
        N3 = PlayerPrefs.GetInt("VariablePuntosN3", 0);
        N4 = PlayerPrefs.GetInt("VariablePuntosN4", 0);
        N5 = PlayerPrefs.GetInt("VariablePuntosN5", 0);
        N6 = PlayerPrefs.GetInt("VariablePuntosN6", 0);
        N7 = PlayerPrefs.GetInt("VariablePuntosN7", 0);
        N8 = PlayerPrefs.GetInt("VariablePuntosN8", 0);
        N9 = PlayerPrefs.GetInt("VariablePuntosN9", 0);
        Debug.Log("Éste es el valor de N1 después de la PlayerPrefsGetInt: " + N1);
        Debug.Log("Éste es el valor de N2 después de la PlayerPrefsGetInt: " + N2);
        Debug.Log("Éste es el valor de N3 después de la PlayerPrefsGetInt: " + N3);
        Debug.Log("Éste es el valor de N4 después de la PlayerPrefsGetInt: " + N4);
        Debug.Log("Éste es el valor de N5 después de la PlayerPrefsGetInt: " + N5);
        Debug.Log("Éste es el valor de N6 después de la PlayerPrefsGetInt: " + N6);
        Debug.Log("Éste es el valor de N7 después de la PlayerPrefsGetInt: " + N7);
        Debug.Log("Éste es el valor de N8 después de la PlayerPrefsGetInt: " + N8);
        Debug.Log("Éste es el valor de N9 después de la PlayerPrefsGetInt: " + N9);
        //Debug.Log("Puntos", + punto.puntos);
    }

    public void Update(){

        
        if (N1==5){
            Debug.Log("Prueba=" + N1);
            Mal.interactable = true;
            //So.interactable = true;
            //De lo contrario muetsra el mensaje de nivel perdido
            
        }

        if(N2==5){
            Debug.Log("Prueba2=" + N2);
            SeguWiFi.interactable = true;

        }

        if(N3==5){
            Debug.Log("Prueba3=" + N3);
            Contra.interactable = true;

        }

        if(N4==5){
            Debug.Log("Prueba4=" + N4);
            TeleConf.interactable = true;

        }

        if(N5==5){
            Debug.Log("Prueba5=" + N5);
            SegNube.interactable = true;

        }

        if(N6==5){
            Debug.Log("Prueba6=" + N6);
            NavSeg.interactable = true;

        }

        if(N7==5){
            Debug.Log("Prueba7=" + N6);
            IngSocial.interactable = true;

        }

        if(N8==5){
            Debug.Log("Prueba8=" + N8);
            CopSeg.interactable = true;

        }

        else{
            Debug.Log("Entra a Else");
        }
    }
    
    public void SistemaOperativo()
    {
        //Botonabloquear.interactable = true;
        SceneManager.LoadScene(1);
        //Debug.Log("DesBloquear botón");
    }

    public void Malware()
    {
        SceneManager.LoadScene(2);
        
    }

    public void SegWiFi()
    {
        SceneManager.LoadScene(3);
        
    }

    public void Contrasenas()
    {
        SceneManager.LoadScene(4);
        
    }

    public void TeleConferencia()
    {
        SceneManager.LoadScene(5);
        
    }

    public void Nube()
    {
        SceneManager.LoadScene(6);
        
    }

    public void NavegacionSegura()
    {
        SceneManager.LoadScene(7);
        
    }

    public void IngenieriaSocial()
    {
        SceneManager.LoadScene(8);
        
    }

    public void CopiasDeSeguridad()
    {
        SceneManager.LoadScene(9);
        
    }

    public void CerrarMenu(){
        ConfirSalir.SetActive(true);
        
    }

    public void ButtonSi(){
        Debug.Log("Cerrando juego");
        Application.Quit();
    }

    public void ButtonNo(){
        ConfirSalir.SetActive(false);
    }

}
