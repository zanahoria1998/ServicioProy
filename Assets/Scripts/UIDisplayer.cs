//Código para renderizar objetos aunque no estén en el canvas, como la tarjeta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDisplayer : MonoBehaviour, IInteractable
{
   
   public GameObject DisplayObject;

   public void Interact(DisplayImage actualDisplay){

    DisplayObject.SetActive(true);
   }
}
