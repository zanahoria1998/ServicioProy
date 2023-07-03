//Código para hacer cambio de nivel
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjetoInteractable : MonoBehaviour
{
    public int i;
    public Textos textos; //Refereciando al Script Textos

    public void OnMouseDown(){ //Al presionar un objeto que tenga este script

        FindObjectOfType<ControlDialogo>().ActivarCartel(textos);//buscará el objeto que tenga el control de dialógo y posteriormente recurrirá al método de activar cartel

    }

    public void SiguienteNivel(int i){ 
        SceneManager.LoadScene(i);
    }
}

