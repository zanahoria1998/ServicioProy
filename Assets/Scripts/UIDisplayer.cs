//Código para activar objetos.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class UIDisplayer : MonoBehaviour, IInteractable
{
   
   int j,i;
   public Textos textos;//Liga el script de Textos a este script
   public List<GameObject> Tarjetas = new List<GameObject>();

   public void Interact(DisplayImage actualDisplay){

      if(Tarjetas.Count == 0){
         Debug.Log("Ya se respondió");
         FindObjectOfType<ControlDialogo>().ActivarCartel(textos);
      } 
      else{
         ElimNull();
         i= Random.Range(0,Tarjetas.Count);
         Debug.Log("Random Lista i" + i);

         Tarjetas[i].SetActive(true);
         for(j=0; j<Tarjetas.Count; j++){
            Tarjetas[j]=null;
         }
         ElimNull();

      }
   }

   public void ElimNull(){
      Debug.Log("Foreach");
      foreach (GameObject tempObject in Tarjetas.ToList())
      {
         if(tempObject == null){
            Debug.Log("else if");
            Tarjetas.Remove(tempObject);
         }
      }
   }
}