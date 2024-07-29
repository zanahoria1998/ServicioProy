//Código para hacer cambio de nivel
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjetoInteractable : MonoBehaviour
{
     
    public Textos textos; //Refereciando al Script Textos

    public void OnMouseDown(){ //Al presionar un objeto que tenga este script

        FindObjectOfType<ControlDialogo>().ActivarCartel(textos);//buscará el objeto que tenga el control de dialógo y posteriormente recurrirá al método de activar cartel

    }
    
    public int i; //Está variable se agrega/modifica manualmente dentro de unity, al referenciar el script nos pide un valor
    public void SiguienteNivel(int i){ 
        SceneManager.LoadScene(i);
    }

}

