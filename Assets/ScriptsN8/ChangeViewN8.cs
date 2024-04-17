//Código para cambio de vista
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeViewN8 : MonoBehaviour, IInteractableN8
{
    public string SpriteName;

    public void InteractN8(DisplayImageN8 actualDisplay){

        actualDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ElementosIndividuales/" + SpriteName);

        actualDisplay.actualEstado = DisplayImageN8.Estado.ChangedView;
    }
}