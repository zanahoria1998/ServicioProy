//Código que genera un arreglo para guardar los textos de los diáologs.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class Textos{

    [TextArea (2,6)] //las cajas de texto ocupaan como minimo 2 y como maximo 6 lineas
    public string[] arrayTextos; //arreglo de textos
    //GameObject[ ] carsInTheScene = GameObject.FindGameObjectsWithTag("car");
    
    //Debug.Log("llamada a arrayTextos");

}

