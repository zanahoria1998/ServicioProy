using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDialogoMenu : MonoBehaviour
{

    private Animator anim;
    private Queue <string> colaDialogos;
    Textos texto;
    [SerializeField] TextMeshProUGUI textoPantalla;

    public void ActivarCartel(Textos textoObjeto)//TextoObjeto es el texto que se le pasa en el script (ObjetoInteractable)
    {
            anim.SetBool("Cartel", true);
            texto = textoObjeto;
            //Debug.Log("Llamada a ActivarCartel");
    }

    public void ActivaTexto()
    {

        colaDialogos.Clear();
        foreach (string textoGuardar in texto.arrayTextos) //recorre el texto dentro del array
        {

            colaDialogos.Enqueue(textoGuardar); //cada palabra del array que se guarda en la variable textoGuardar, la agrega a la cola

            /*if (textoGuardar == "Respuesta Correcta"){
                Trofeo();
                CierraCartel();
                //Debug.Log("if de texto wardar jala");
            } 
            else if (textoGuardar == "Respuesta Incorrecta"){
                Derrota();
                CierraCartel();
                //Debug.Log("Respuesta incorrecta, función");
                //Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
            }
            else if(textoGuardar == "Esta pregunta ya fue respondida"){
                CierraCartel();
            }*/
        }

        SiguienteFrase();
    }

    public void SiguienteFrase()
    {
        if (colaDialogos.Count == 0)
        {
            CierraCartel();
            return;
        }

        string fraseActual = colaDialogos.Dequeue();
        textoPantalla.text = fraseActual;
        //Debug.Log("Llamada a SiguienteFrase");
    }

    public void CierraCartel()
    {
        anim.SetBool("Cartel", false);

    }

    // Start is called before the first frame update
    void Start()
    {
        //puntos=0;
        anim = GetComponent<Animator>();
       
        colaDialogos = new Queue<string>();
    }

}
