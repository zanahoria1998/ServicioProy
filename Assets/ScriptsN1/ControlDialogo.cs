using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ControlDialogo : MonoBehaviour
{

    public GameObject BotonSN;
    public GameObject ImagenSN;
    public GameObject BotonNP;
    public GameObject ImagenNP;
    public GameObject PanelApertura;
    public GameObject Prefabtrofeo;
    //private GameObject botonPausa;
    public int puntosN1; //contador
    public int puntosNegativos; //contador
    private Animator anim;
    private Queue <string> colaDialogos;
    Textos texto;
    Image imagenPanel;
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
        puntosN1=PlayerPrefs.GetInt("VariablePuntos", puntosN1=0);
    
        //puntosN1=0;
        anim = GetComponent<Animator>();

       
        colaDialogos = new Queue<string>();
    }

     public void Update(){
        if (puntosN1 == 5){
            ButtonSN();
        } 
        /*else if (puntosNegativos <= 5){
            NivelPerdido();
            //PlayerPrefs.DeleteKey("VariablePuntos");
        } */

     }

    void RevisionPuntaje(){


        if(puntosN1 == 1){ //puntaje = 0
            GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129, 68, 0), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }

        else if(puntosN1 == 2){ // puntaje = 1
            GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129, 35, 3), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }

        else if(puntosN1 == 3){ //Puntaje = 2
            GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129, 1, 3), transform.rotation) as GameObject;
                                                                    
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }
        else if(puntosN1 == 4){ // puntaje = 3
            GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129,-32,0), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));
        }
        else if(puntosN1 == 5){ // puntaje = 4
            GameObject trofeo = Instantiate(Prefabtrofeo, new Vector3(129,-65,0), transform.rotation) as GameObject;
            trofeo.transform.SetParent(GameObject.FindGameObjectWithTag("ICanva").transform, false);
            Destroy(GameObject.FindGameObjectWithTag("Tarjeta"));

            //Debug.Log("Se han juntado los 5 trofeos");
            //FindObjectOfType<ControlDialogo>().ActivarCartel(textos);
        }
    }


    public void Trofeo(){
        puntosN1++;
        Debug.Log("Puntos" + puntosN1);
        RevisionPuntaje();
        PlayerPrefs.SetInt("VariablePuntos", puntosN1);
        /*if (puntosN1 == 5){
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
            //PlayerPrefs.DeleteKey("VariablePuntos");
        } 
    }

    public void ButtonSN(){
        Time.timeScale = 0f;
        Debug.Log("PausaReloj");
        ImagenSN.SetActive(true);
        BotonSN.SetActive(true);
        //PanelApertura.Image.SetActive(false);
        imagenPanel = PanelApertura.GetComponent<Image>();//.enabled = false;
        imagenPanel.enabled = false;

        //botonPausa.SetActive(false);
    }

     public void NivelPerdido(){
        Time.timeScale = 0f;
        ImagenNP.SetActive(true);
        BotonNP.SetActive(true);
    }
}
