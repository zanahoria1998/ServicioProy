//Código para desaparecer la tarjeta y seguir jugando.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuitarTarjeta : MonoBehaviour
{

    public bool finalizado {get; private set; }

    public GameObject BPausa;
    private GameObject displayImage;
    // Start is called before the first frame update
    void Start()
    {
        displayImage = GameObject.Find("DisplayImage");
    }

    // Update is called once per frame
    void Update()
    {
        HideDisplay();
    }

    public void HideDisplay(){

        if(Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject()){

            this.gameObject.SetActive(false);
            Debug.Log("Primer If de quitar tarjeta");
            //BPausa.SetActive(true);
        }

        if(displayImage.GetComponent<DisplayImage>().actualEstado == DisplayImage.Estado.normal){

            this.gameObject.SetActive(false);
            Debug.Log("Segundo If de quitar tarjeta");
            //BPausa.SetActive(true);
        }
    }
}
