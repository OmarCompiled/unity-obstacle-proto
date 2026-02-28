using Mono.Cecil.Cil;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Color baseColor;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        baseColor = meshRenderer.material.color;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            meshRenderer.material.color = Color.crimson;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            meshRenderer.material.color = Color.dimGray;
        }
    }
}
