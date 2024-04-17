//Código para desaparecer la tarjeta y seguir jugando.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuitartarjetaN9 : MonoBehaviour
{

    public bool finalizado {get; private set; }

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
        }

        if(displayImage.GetComponent<DisplayImageN9>().actualEstado == DisplayImageN9.Estado.normal){

            this.gameObject.SetActive(false);
            Debug.Log("Segundo If de quitar tarjeta");
        }
    }
}