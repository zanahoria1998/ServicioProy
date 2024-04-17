//Código que contiene los botones de derecha, izquierda y retunr )en caso de zoom) 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandlerN9 : MonoBehaviour
{
   private DisplayImageN9 actualDisplay;

   private float initialCameraSize;
   private Vector3 initialCameraPosition;

   void Start(){
    actualDisplay = GameObject.Find("DisplayImage").GetComponent<DisplayImageN9>();
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
      
      if(actualDisplay.actualEstado == DisplayImageN9.Estado.zoom){

         GameObject.Find("DisplayImage").GetComponent<DisplayImageN9>().actualEstado = DisplayImageN9.Estado.normal;
         var zoomInObjects = FindObjectsOfType<ZoomInObjectN9>();
         foreach(var zoomInObject in zoomInObjects)
         {
            zoomInObject.gameObject.layer = 0;
         }

         Camera.main.orthographicSize = initialCameraSize;
         Camera.main.transform.position = initialCameraPosition;

      }

      else{

         actualDisplay.GetComponent<SpriteRenderer>().sprite =
         Resources.Load<Sprite>("EscenaN9/Pared" + actualDisplay.ParedActual);

         actualDisplay.actualEstado = DisplayImageN9.Estado.normal;
      }
   }

}