//Código para cambio de vista
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeViewN6 : MonoBehaviour, IInteractableN6
{
    public string SpriteName;

    public void InteractN6(DisplayImageN6 actualDisplay){

        actualDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ElementosIndividuales/" + SpriteName);

        actualDisplay.actualEstado = DisplayImageN6.Estado.ChangedView;
    }
}