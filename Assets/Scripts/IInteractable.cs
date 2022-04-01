//Interface pública para objetos interactables, llama y/o utiliza el script interact
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable{

    void Interact(DisplayImage actualDisplay);
}