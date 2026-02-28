using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using System;
using System.Transactions;
using Unity.Cinemachine;

public class PlayerController : MonoBehaviour
{
    #pragma warning disable
    private Rigidbody rigidbody;
    #pragma warning restore
    // private Vector3 direction = Vector3.zero;
    private float verticalInput;
    private float horizontalInput;
    private float verticalSpeed;
    private float horizontalSpeed;
    private float jumpForce;
    private bool isGrounded = true;

    [SerializeField]
    float speed = 10.0f;

    void Start()
    {
        float gh = 4.0f * Physics.gravity.magnitude;

        rigidbody = GetComponent<Rigidbody>();
        jumpForce = rigidbody.mass * Mathf.Sqrt(2.0f * gh);
    }

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        verticalSpeed = verticalInput * Time.deltaTime * speed;
        horizontalSpeed = horizontalInput * Time.deltaTime * speed;
        // direction = new Vector3(horizontalInput, 0.0f, verticalInput);

        transform.Translate(Vector3.forward * verticalSpeed);
        transform.Translate(Vector3.right * horizontalSpeed);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            rigidbody.AddForce(Vector3.up *  jumpForce, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor") isGrounded = true;
    }

    void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Floor") isGrounded = true;
    }

    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Floor") isGrounded = false;
    }
}
