using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuardarNombre : MonoBehaviour
{
    public InputField inputText; // Campo de entrada para el nombre
    public Text textoNombre; // Componente Text para mostrar el nombre guardado
    public Image luz;
    public GameObject botonAceptar;
    public GameObject panelInput; // Panel que contiene el InputField y el botón
    public GameObject panelNombre; // Panel donde se mostrará el nombre guardado

    public GameObject sonido;
    public GameObject sonidoMute;

    private void Awake()
    {
        luz.color = Color.red;
    }

    private void Start()
    {
        //PlayerPrefs.DeleteAll();
        // Verificar si ya existe un nombre guardado
        if (PlayerPrefs.HasKey("nombre1"))
        {
            string nombreGuardado = PlayerPrefs.GetString("nombre1");
            textoNombre.text = nombreGuardado; // Muestra el nombre guardado
            panelInput.SetActive(false); // Oculta el panel de entrada
            panelNombre.SetActive(true); // Activa el panel del nombre guardado
        }
        else
        {
            panelInput.SetActive(true); // Muestra el panel de entrada si no hay nombre
            panelNombre.SetActive(false); // Oculta el panel del nombre guardado
        }
    }

    private void Update()
    {
        if (panelInput.activeSelf) // Solo valida si el panel de entrada está activo
        {
            if (inputText.text.Length < 4)
            {
                luz.color = Color.red;
                botonAceptar.SetActive(false);
            }
            else
            {
                luz.color = Color.green;
                botonAceptar.SetActive(true);
            }
        }
    }

    public void aceptar()
    {
        string nombre = inputText.text;
        PlayerPrefs.SetString("nombre1", nombre); // Guarda el nombre
        textoNombre.text = nombre; // Actualiza el texto con el nombre guardado
        Debug.Log("Este es el nombre: " + nombre);
        panelInput.SetActive(false); // Oculta el panel de entrada
        panelNombre.SetActive(true); // Muestra el panel del nombre guardado
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
