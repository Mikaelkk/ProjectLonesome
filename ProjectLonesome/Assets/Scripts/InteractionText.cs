using UnityEngine;
using UnityEngine.UI;

public class InteractionText : MonoBehaviour
{
    public Text interactText;

    public void updateText(string newText)
    {
        interactText.text = newText;
    }
}
