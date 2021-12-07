using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
   private DisplayImage actualDisplay;

   private float initialCameraSize;
   private Vector3 initialCameraPosition;

   void Start(){
    actualDisplay = GameObject.Find("DisplayImage").GetComponent<DisplayImage>();
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
      
      if(actualDisplay.actualEstado == DisplayImage.Estado.zoom){

         GameObject.Find("DisplayImage").GetComponent<DisplayImage>().actualEstado = DisplayImage.Estado.normal;
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
         Resources.Load<Sprite>("Escena/Pared" + actualDisplay.ParedActual);

         actualDisplay.actualEstado = DisplayImage.Estado.normal;
      }
   }

}
