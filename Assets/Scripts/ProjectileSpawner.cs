using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField]
    Transform target;

    [SerializeField]
    GameObject projectile;

    [SerializeField]
    Projectile projectileScript;

    private float time = 2.0f;

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0.0f)
        {
            projectileScript.target = target;
            Instantiate(projectile);
            time = Random.Range(2.0f, 5.0f);
        }
    }
}
