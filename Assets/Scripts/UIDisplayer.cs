//Código para activar objetos.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDisplayer : MonoBehaviour, IInteractable
{
   
   int j,i;
   public GameObject[] TarjetasRandom;

   public void Interact(DisplayImage actualDisplay){

      i = Random.Range(0,TarjetasRandom.Length);
      Debug.Log("esto es i "+ i);
      TarjetasRandom[i].SetActive(true);
      for(j=0; j<TarjetasRandom.Length; j++){
            TarjetasRandom[j]=null;
      }
   }
}
