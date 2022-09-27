//Código para cambio de vista
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeViewN2 : MonoBehaviour, IInteractableN2
{
    public string SpriteName;

    public void InteractN2(DisplayImageN2 actualDisplay){

        actualDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ElementosIndividuales/" + SpriteName);

        actualDisplay.actualEstado = DisplayImageN2.Estado.ChangedView;
    }
}