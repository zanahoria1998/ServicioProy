//Código para cambio de vista
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeViewN5 : MonoBehaviour, IInteractableN5
{
    public string SpriteName;

    public void InteractN5(DisplayImageN5 actualDisplay){

        actualDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ElementosIndividuales/" + SpriteName);

        actualDisplay.actualEstado = DisplayImageN5.Estado.ChangedView;
    }
}