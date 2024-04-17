//Código para hacer zoom a los objetos
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInObjectN5 : MonoBehaviour, IInteractableN5
{
    public float ZoomRatio = 0.2f;

    public void InteractN5(DisplayImageN5 actualDisplay){

        Camera.main.orthographicSize *= ZoomRatio;
        Camera.main.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 
            Camera.main.transform.position.z);

        gameObject.layer = 2;
        actualDisplay.actualEstado = DisplayImageN5.Estado.zoom;

        ConstrainCamera();
    }

    //Está función lo que hace, es que si se hace un zoom fuera de los limites de la camara, quita lo que esta fuera del limite
    //Haciendo que el zoom este unicamente dentro de la escena
    void ConstrainCamera(){

        var height = Camera.main.orthographicSize; 
        var width = height * Camera.main.aspect;

        var CameraBounds = GameObject.Find("CameraBounds");

        if(Camera.main.transform.position.x + width > CameraBounds.transform.position.x + CameraBounds.GetComponent <BoxCollider2D>().size.x / 2)
        {
            Camera.main.transform.position += new Vector3(CameraBounds.transform.position.x + CameraBounds.GetComponent <BoxCollider2D>().size.x / 2 - 
                (Camera.main.transform.position.x + width), 0, 0);
        }

        if(Camera.main.transform.position.x - width > CameraBounds.transform.position.x + CameraBounds.GetComponent <BoxCollider2D>().size.x / 2)
        {
            Camera.main.transform.position += new Vector3(CameraBounds.transform.position.x + CameraBounds.GetComponent <BoxCollider2D>().size.x / 2 - 
                (Camera.main.transform.position.x + width), 0, 0);
        }

        if(Camera.main.transform.position.x + height > CameraBounds.transform.position.x + CameraBounds.GetComponent <BoxCollider2D>().size.x / 2)
        {
            Camera.main.transform.position += new Vector3(CameraBounds.transform.position.x + CameraBounds.GetComponent <BoxCollider2D>().size.x / 2 - 
                (Camera.main.transform.position.x + width), 0, 0);
        }

        if(Camera.main.transform.position.x - height > CameraBounds.transform.position.x + CameraBounds.GetComponent <BoxCollider2D>().size.x / 2)
        {
            Camera.main.transform.position += new Vector3(CameraBounds.transform.position.x + CameraBounds.GetComponent <BoxCollider2D>().size.x / 2 - 
                (Camera.main.transform.position.x + width), 0, 0);
        }
    }
}