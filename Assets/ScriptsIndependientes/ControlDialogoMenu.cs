using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDialogoMenu : MonoBehaviour
{
    private Animator anim;
    private List<string> listaDialogos;
    private int indiceActual; // Índice para la posición actual en la lista de diálogos
    public GameObject SiguienteFraseB;
    public GameObject AnteriorFraseB;
    public GameObject OmitirFraseB;
    Textos texto;
    [SerializeField] TextMeshProUGUI textoPantalla;

    void Start()
    {
        anim = GetComponent<Animator>();
        listaDialogos = new List<string>();
    }

    public void ActivarCartel(Textos textoObjeto)
    {
        anim.SetBool("Cartel", true);
        texto = textoObjeto;
        SiguienteFraseB.SetActive(true);
        AnteriorFraseB.SetActive(true);
        OmitirFraseB.SetActive(true);
    }

    public void ActivaTexto()
    {
        listaDialogos.Clear();
        foreach (string textoGuardar in texto.arrayTextos)
        {
            listaDialogos.Add(textoGuardar);
        }

        indiceActual = 0; // Empezamos desde el primer texto
        MostrarFraseActual();
    }

    public void MostrarFraseActual()
    {
        if (indiceActual >= 0 && indiceActual < listaDialogos.Count)
        {
            textoPantalla.text = listaDialogos[indiceActual];
        }
    }

    public void SiguienteFrase()
    {
        if (indiceActual < listaDialogos.Count - 1)
        {
            indiceActual++;
            MostrarFraseActual();
        }
        else
        {
            CierraCartel();
        }
    }

    public void FraseAnterior()
    {
        if (indiceActual > 0)
        {
            indiceActual--;
            MostrarFraseActual();
        }
    }

    public void CierraCartel()
    {
        anim.SetBool("Cartel", false);
        SiguienteFraseB.SetActive(false);
        AnteriorFraseB.SetActive(false);
        OmitirFraseB.SetActive(false);
    }
}
