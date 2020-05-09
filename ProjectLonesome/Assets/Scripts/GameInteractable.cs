using UnityEngine;

[CreateAssetMenu(fileName = "New Interactable", menuName = "Interactables/New")]
public class GameInteractable : ScriptableObject
{
    new public string name = "New Interactable";
    public Sprite sprite = null;
    public string interactionText = "Default";
}
