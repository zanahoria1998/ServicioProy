using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDialogo : MonoBehaviour
{

    public GameObject Prefabtrofeo;
    private int puntos; //contador
    private Animator anim;
    private Queue <string> colaDialogos;
    Textos texto;
    [SerializeField] TextMeshProUGUI textoPantalla;

    public void ActivarCartel(Textos textoObjeto)//TextoObjeto es el texto que se le pasa en el script (ObjetoInteractable)
    {
            anim.SetBool("Cartel", true);
            texto = textoObjeto;
            Debug.Log("Llamada a ActivarCartel");
    }

    public void ActivaTexto()
    {

        colaDialogos.Clear();
        foreach (string textoGuardar in texto.arrayTextos) //recorre el texto dentro del array
        {

            colaDialogos.Enqueue(textoGuardar); //cada palabra del array que se guarda en la variable textoGuardar, la agrega a la cola

            if (textoGuardar == "Respuesta Correcta"){
                Trofeo();
                Debug.Log("if de texto wardar jala");
            } 
            else if (textoGuardar == "Respuesta Incorrecta"){
                Debug.Log("Respuesta incorecta, función");
                Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
            }
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
        Debug.Log("Llamada a SiguienteFrase");
    }

    public void CierraCartel()
    {
        //CartelPrueba=false;
        anim.SetBool("Cartel", false);
        Debug.Log("Llamada a CierraCartel");
    }

    // Start is called before the first frame update
    void Start()
    {
        //puntos=trofeos.Length;
        puntos=0;
        anim = GetComponent<Animator>();
       
        colaDialogos = new Queue<string>();
        //destruir= GameObject.FindGameObjectWithTag("Tarjeta").GetComponent<QuitarTarjeta>();
    }

    void RevisionPuntaje(){


        if(puntos == 0){ //puntaje = 0
            GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129, 68, 0), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }

        else if(puntos == 1){ // puntaje = 1
            GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129, 35, 3), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }

        else if(puntos == 2){ //Puntaje = 2
            GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129, 1, 3), transform.rotation) as GameObject;
                                                                    //129,-32,0
                                                                    //129,-65,0
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }
        else if(puntos == 3){ // puntaje = 1
            GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129,-32,0), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }
        else if(puntos == 4){ // puntaje = 1
            GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129,-65,0), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }
    }


    public void Trofeo(){
        Debug.Log("Esto es puntos" + puntos);
        RevisionPuntaje();
        puntos++;
    }
}
