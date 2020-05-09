using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactions : Interactable
{
    public GameInteractable interactable;

    public InteractionText text;

    public override void Interact()
    {
        base.Interact();
        ShowText();
    }

    void ShowText()
    {
        Debug.Log("Interacting with " + interactable.name);
        text.updateText(interactable.interactionText);
        
    }
}
