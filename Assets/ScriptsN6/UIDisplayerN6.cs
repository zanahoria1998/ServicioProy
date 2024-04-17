//Código para activar objetos.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class UIDisplayerN6 : MonoBehaviour, IInteractableN6
{
   
   int j,i;
   public Textos textos;//Liga el script de Textos a este script
   public List<GameObject> Tarjetas = new List<GameObject>();

   public void InteractN6(DisplayImageN6 actualDisplay){

      ElimNull();
      ListaVacia();
      for(j=0; j<Tarjetas.Count; j++){
         if (i==j){
            Debug.Log("i=j");
         }else{
            Tarjetas[j]=null;
         }
      }
      ElimNull();
   }

   public void ListaVacia(){
      Debug.Log("Fun Lista Vacia");
      if(Tarjetas.Count == 0){
         Debug.Log("Ya se respondió");
         FindObjectOfType<ControlDialogo>().ActivarCartel(textos);
      } 
      else{
         i= Random.Range(0,Tarjetas.Count);
         Debug.Log("Random Lista i" + i);
         Tarjetas[i].SetActive(true);
      }
   }

   public void ElimNull(){
      Debug.Log("Foreach");
      foreach (GameObject tempObject in Tarjetas.ToList())
      {
         if(tempObject == null){
            Debug.Log("remove");
            Tarjetas.Remove(tempObject);
         }
      }
   }
}