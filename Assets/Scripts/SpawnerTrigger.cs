using UnityEngine;

public class SpawnerTrigger : MonoBehaviour
{
    private GameObject spawner;

    void Start()
    {
        spawner = GameManager.Instance.projectileSpawner.gameObject;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            spawner.SetActive(!spawner.activeSelf); // inverter
        }
    }
}
