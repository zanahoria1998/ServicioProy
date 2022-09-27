//Código que contiene los botones de derecha, izquierda y retunr )en caso de zoom) 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandlerN2 : MonoBehaviour
{
   private DisplayImageN2 actualDisplay;

   private float initialCameraSize;
   private Vector3 initialCameraPosition;

   void Start(){
    actualDisplay = GameObject.Find("DisplayImage").GetComponent<DisplayImageN2>();
    initialCameraSize = Camera.main.orthographicSize;
    initialCameraPosition = Camera.main.transform.position;
   }

   public void ClickFlechaDercha(){
    actualDisplay.ParedActual = actualDisplay.ParedActual + 1;
   }

   public void ClickFlechaIzquierda(){
    actualDisplay.ParedActual = actualDisplay.ParedActual - 1;
   }

   public void OnClickReturn(){
      
      if(actualDisplay.actualEstado == DisplayImageN2.Estado.zoom){

         GameObject.Find("DisplayImage").GetComponent<DisplayImageN2>().actualEstado = DisplayImageN2.Estado.normal;
         var zoomInObjects = FindObjectsOfType<ZoomInObject>();
         foreach(var zoomInObject in zoomInObjects)
         {
            zoomInObject.gameObject.layer = 0;
         }

         Camera.main.orthographicSize = initialCameraSize;
         Camera.main.transform.position = initialCameraPosition;

      }

      else{

         actualDisplay.GetComponent<SpriteRenderer>().sprite =
         Resources.Load<Sprite>("EscenaN2/Pared" + actualDisplay.ParedActual);

         actualDisplay.actualEstado = DisplayImageN2.Estado.normal;
      }
   }

}