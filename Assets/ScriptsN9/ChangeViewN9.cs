//Código para cambio de vista
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeViewN9 : MonoBehaviour, IInteractableN9
{
    public string SpriteName;

    public void InteractN9(DisplayImageN9 actualDisplay){

        actualDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ElementosIndividuales/" + SpriteName);

        actualDisplay.actualEstado = DisplayImageN9.Estado.ChangedView;
    }
}