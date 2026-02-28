using UnityEngine;

public class CollisionsManager : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Floor")) return;
        GameManager.Collisions++;
    }
}
