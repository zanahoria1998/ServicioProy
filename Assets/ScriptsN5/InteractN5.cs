//Script para los objetos con etiqueta interactable
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractN5 : MonoBehaviour
{
    private DisplayImageN5 actualDisplay;

    void Start(){
        actualDisplay = GameObject.Find("DisplayImage").GetComponent<DisplayImageN5>();
    }

    void Update(){

        if(Input.GetMouseButtonDown(0)){
            Vector2 rayPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPosition, Vector2.zero, 100); 

            if(hit && hit.transform.tag == "Interactable"){

                hit.transform.GetComponent<IInteractableN5>().InteractN5(actualDisplay);
            }
        }
    }


}