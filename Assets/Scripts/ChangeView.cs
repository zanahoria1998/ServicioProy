//Código para cambio de vista
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour, IInteractable
{
    public string SpriteName;

    public void Interact(DisplayImage actualDisplay){

        actualDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ElementosIndividuales/" + SpriteName);

        actualDisplay.actualEstado = DisplayImage.Estado.ChangedView;
    }
}
