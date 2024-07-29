using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDialogoN9 : MonoBehaviour
{

    public GameObject BotonSN;
    public GameObject ImagenSN;
    public GameObject BotonNP;
    public GameObject ImagenNP;
    public GameObject Prefabtrofeo;
    public int puntosN9; //contador
    public int puntosNegativos; //contador
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

            if (textoGuardar == "Respuesta Correcta"){
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
        //Debug.Log("Llamada a SiguienteFrase");
    }

    public void CierraCartel()
    {
        anim.SetBool("Cartel", false);

    }

    // Start is called before the first frame update
    void Start()
    {
        puntosN9=PlayerPrefs.GetInt("VariablePuntosN9", puntosN9=0);
        //puntosN9=0;
        anim = GetComponent<Animator>();
       
        colaDialogos = new Queue<string>();
    }

    public void Update(){
        if (puntosN9 == 5){
            ButtonSN();
        } 

     }

    void RevisionPuntaje(){


        if(puntosN9 == 1){ //puntaje = 0
            GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129, 68, 0), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }

        else if(puntosN9 == 2){ // puntaje = 1
            GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129, 35, 3), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }

        else if(puntosN9 == 3){ //Puntaje = 2
            GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129, 1, 3), transform.rotation) as GameObject;
                                                                    
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }
        else if(puntosN9 == 4){ // puntaje = 3
            GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129,-32,0), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }
        else if(puntosN9 == 5){ // puntaje = 4
            GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129,-65,0), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));

            //Debug.Log("Se han juntado los 5 trofeos");
            //FindObjectOfType<ControlDialogo>().ActivarCartel(textos);
        }
    }


    public void Trofeo(){
        puntosN9++;
        RevisionPuntaje();
        PlayerPrefs.SetInt("VariablepuntosN9", puntosN9);
        /*if (puntosN9 == 5){
            ButtonSN();
        } */
    }

    void RevisionPuntajeNegativo(){


        if(puntosNegativos == 1){ //puntaje = 0
            /*GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129, 68, 0), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);*/
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }

        else if(puntosNegativos == 2){ // puntaje = 1
            /*GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129, 35, 3), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);*/
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }

        else if(puntosNegativos == 3){ //Puntaje = 2
            /*GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129, 1, 3), transform.rotation) as GameObject;                                                  
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);*/
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }
        else if(puntosNegativos == 4){ // puntaje = 3
            /*GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129,-32,0), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);*/
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }
        else if(puntosNegativos == 5){ // puntaje = 4
            /*GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129,-65,0), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);*/
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));

            //Debug.Log("Se han juntado los 5 trofeos");
            //FindObjectOfType<ControlDialogo>().ActivarCartel(textos);
        }
    }


    public void Derrota(){
        puntosNegativos++;
        RevisionPuntajeNegativo();
        if (puntosNegativos <= 5){
            NivelPerdido();
        } 
    }

    public void ButtonSN(){
        ImagenSN.SetActive(true);
        BotonSN.SetActive(true);
    }

     public void NivelPerdido(){
        ImagenNP.SetActive(true);
        BotonNP.SetActive(true);
    }
}
