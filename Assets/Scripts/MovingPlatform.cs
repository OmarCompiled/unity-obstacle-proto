using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private Vector3 initialPosition;
    private Vector3 finalPosition;
    private float time = 5.0f;
    private Vector3 direction;

    void Start()
    {
        initialPosition = transform.position;
        finalPosition = initialPosition - (5.0f * Vector3.right);
        direction = finalPosition - initialPosition;
    }

    void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0.0f)
        {
            direction *= -1.0f;
            time = 5.0f;
        }   
        
        transform.Translate(direction * Time.deltaTime);
    }
}
