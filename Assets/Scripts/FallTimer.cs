using UnityEngine;

public class FallTimer : MonoBehaviour
{
    #pragma warning disable 
    Rigidbody rigidbody;
    #pragma warning restore
    MeshRenderer meshRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody    = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();

        rigidbody.useGravity = false;
        meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= 3.0f)
        {
            rigidbody.useGravity = true;
            meshRenderer.enabled = true;
        }
    }
}
