using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ControlDialogoN9 : MonoBehaviour
{

    //public GameObject PanelFinal;
    //public GameObject PanelFinal;
    public GameObject BotonNP;
    public GameObject ImagenNP;
    public GameObject Prefabtrofeo;
    public int puntosN9; //contador
    public int puntosNegativos; //contador
    private Animator anim;
    private Queue <string> colaDialogos;
    Textos texto;
    [SerializeField] TextMeshProUGUI textoPantalla;
    [SerializeField] private AnimationClip animacionFinal;

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

        //anim2 = animacionFinal;
    }

    public void Update(){
        if (puntosN9 == 5){
            StartCoroutine(ButtonSN());
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
        PlayerPrefs.SetInt("VariablePuntosN9", puntosN9);
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

    IEnumerator ButtonSN(){
        //Time.timeScale = 0f;
        //ImagenSN.SetActive(true);
        //PanelFinal.SetActive(true);

        anim.SetTrigger("Terminar");
        Debug.Log("Después de El trigger");
        yield return new WaitForSeconds(animacionFinal.length);
        Debug.Log("Después de Yield Return" + animacionFinal.length);
        //anim.SetTrigger("Finalizar");
        SceneManager.LoadScene(10);
    }

     public void NivelPerdido(){
        Time.timeScale = 0f;
        ImagenNP.SetActive(true);
        BotonNP.SetActive(true);
    }
}
