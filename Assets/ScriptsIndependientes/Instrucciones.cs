using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrucciones : MonoBehaviour
{
    //public GameObject InstruccionesDiag;
    public Textos textos; //Refereciando al Script Textos

    /*void Start(){
        FindObjectOfType<ControlDialogoMenu>().ActivarCartel(textos);
    }*/

    public void DiagIns(){ //Al presionar un objeto que tenga este script
        Debug.Log("Entra a función de botón jsjsjs");
        FindObjectOfType<ControlDialogoMenu>().ActivarCartel(textos);//buscará el objeto que tenga el control de dialógo y posteriormente recurrirá al método de activar cartel
        //InstruccionesDiag.SetActive(true);
    }
}


