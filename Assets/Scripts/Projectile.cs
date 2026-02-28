using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [HideInInspector]
    public Transform target;

    [SerializeField]
    float speed = 5.0f;

    private Vector3 initialPosition;
    private float time = 5.0f;

    void Start()
    {
        float coord = Random.Range(3.0f, 10.0f);
        initialPosition = target.position + new Vector3(coord, coord, coord);
        transform.position = initialPosition;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        //transform.Translate(Time.deltaTime  * (target.position - transform.position));
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * speed);
        if(time <= 0.0f)
        {
            Destroy(gameObject);
            time = 5.0f;
        }
    }
}
