using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isInteracting = false;

    public GameObject interactionUI;

    public void ShowInteraction()
    {
        if (isInteracting)
        {
            interactionUI.SetActive(true);
        }
    }

    public void HideInteraction()
    {
        if (!isInteracting)
        {
            interactionUI.SetActive(false);
        }
    }
}
