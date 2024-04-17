//Código para cambiar de cuartos
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviourN9 : MonoBehaviour
{
    public enum ButtonId {

        roomChangeButton, returnButton
    }

    public ButtonId ThisButtonId;

    private DisplayImageN9 actualDisplay;

    void Start(){
        actualDisplay = GameObject.Find("DisplayImage").GetComponent<DisplayImageN9>();
    }

    void Update(){
        esconderDisplay();
        Display();
    }

    void esconderDisplay(){

        if(actualDisplay.actualEstado == DisplayImageN9.Estado.normal && ThisButtonId == ButtonId.returnButton){

            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, 
                                                    GetComponent<Image>().color.b, 0);

            GetComponent<Button>().enabled = false;
            this.transform.SetSiblingIndex(0);
        }

        if(!(actualDisplay.actualEstado == DisplayImageN9.Estado.normal) && ThisButtonId == ButtonId.roomChangeButton){

            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, 
                                                    GetComponent<Image>().color.b, 0);

            GetComponent<Button>().enabled = false;
            this.transform.SetSiblingIndex(0);
        }
    }

    void Display(){

        if(!(actualDisplay.actualEstado == DisplayImageN9.Estado.normal) && ThisButtonId == ButtonId.returnButton){

            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, 
                                                    GetComponent<Image>().color.b, 1);

            GetComponent<Button>().enabled = true;
        }

        if(actualDisplay.actualEstado == DisplayImageN9.Estado.normal && ThisButtonId == ButtonId.roomChangeButton){

            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, 
                                                    GetComponent<Image>().color.b, 1);

            GetComponent<Button>().enabled = true;
        }
    }

}