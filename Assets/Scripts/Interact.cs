//Script para los objetos con etiqueta interactable
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    private DisplayImage actualDisplay;

    void Start(){
        actualDisplay = GameObject.Find("DisplayImage").GetComponent<DisplayImage>();
    }

    void Update(){

        if(Input.GetMouseButtonDown(0)){
            Vector2 rayPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPosition, Vector2.zero, 100); 

            if(hit && hit.transform.tag == "Interactable"){

                hit.transform.GetComponent<IInteractable>().Interact(actualDisplay);
            }
        }
    }


}
