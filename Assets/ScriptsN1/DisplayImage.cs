//Código que contiene las variables y contadores para hacer zoom, cambio de vista y avanzar o retroceder entre paredes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayImage : MonoBehaviour
{
    
    public enum Estado{

        normal, zoom, ChangedView
    };

    public Estado actualEstado { get; set; }

    public int ParedActual{
        get{
            return actualPared;
        }

        set{
            if (value == 5)
                actualPared = 1;
            else if (value == 0)
                actualPared = 4;
            else 
                actualPared = value;

        }
    }

    private int actualPared;
    private int previaPared;

    void Start(){
        previaPared = 0; 
        actualPared = 1;
    }

    void Update(){
        if (actualPared != previaPared)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Escena/Pared" + actualPared.ToString());
        }

        previaPared = actualPared;
    }
}
