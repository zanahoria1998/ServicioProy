//Código para activar objetos.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class UIDisplayerN8 : MonoBehaviour, IInteractableN8
{
   
   int j,i;
   public Textos textos;//Liga el script de Textos a este script
   public List<GameObject> Tarjetas = new List<GameObject>();
   public GameObject BPausa;

   public void InteractN8(DisplayImageN8 actualDisplay){

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
         FindObjectOfType<ControlDialogoN8>().ActivarCartel(textos);
      } 
      else{
         i= Random.Range(0,Tarjetas.Count);
         Debug.Log("Random Lista i" + i);
         Tarjetas[i].SetActive(true);
         BPausa.SetActive(false);
         Debug.Log("Se abre tarjeta");
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