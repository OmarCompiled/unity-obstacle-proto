using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    Text collisionsDisplay;

    public void UpdateCollisionDisplay(int collisions)
    {
        collisionsDisplay.color = Color.black;
        collisionsDisplay.text = "Collisions: " + collisions.ToString();
    }
}
