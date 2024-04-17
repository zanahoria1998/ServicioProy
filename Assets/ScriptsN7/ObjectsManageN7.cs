//Código para manejar los objetos en cada habitación de forma independiente; es decir, que un zoomobject en la pared 1 no afecte a la pared2
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsManageN7 : MonoBehaviour
{
    private DisplayImageN7 actualDisplay;

    public GameObject[] ObjectsToManage;
    //public GameObject[] UIRenderObjects;

    void Start(){

        actualDisplay = GameObject.Find("DisplayImage").GetComponent<DisplayImageN7>();
        //RenderUI();
    }

    void Update(){

        ManageObjects();
    }

    void ManageObjects(){

        for(int i=0; i < ObjectsToManage.Length; i++){

            if(ObjectsToManage[i].name == actualDisplay.GetComponent<SpriteRenderer>().sprite.name){

                ObjectsToManage[i].SetActive(true);
            }

            else{
                ObjectsToManage[i].SetActive(false);
            }
        }
    }
}