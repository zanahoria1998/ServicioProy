//Código para cambio de vista
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeViewN3 : MonoBehaviour, IInteractableN3
{
    public string SpriteName;

    public void InteractN3(DisplayImageN3 actualDisplay){

        actualDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ElementosIndividuales/" + SpriteName);

        actualDisplay.actualEstado = DisplayImageN3.Estado.ChangedView;
    }
}