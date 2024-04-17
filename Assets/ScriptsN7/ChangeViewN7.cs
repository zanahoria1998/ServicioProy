//Código para cambio de vista
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeViewN7 : MonoBehaviour, IInteractableN7
{
    public string SpriteName;

    public void InteractN7(DisplayImageN7 actualDisplay){

        actualDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ElementosIndividuales/" + SpriteName);

        actualDisplay.actualEstado = DisplayImageN7.Estado.ChangedView;
    }
}