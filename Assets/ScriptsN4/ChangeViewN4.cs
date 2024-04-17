//Código para cambio de vista
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeViewN4 : MonoBehaviour, IInteractableN4
{
    public string SpriteName;

    public void InteractN4(DisplayImageN4 actualDisplay){

        actualDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ElementosIndividuales/" + SpriteName);

        actualDisplay.actualEstado = DisplayImageN4.Estado.ChangedView;
    }
}