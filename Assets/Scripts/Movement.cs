using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rigidbody;

    [SerializeField] float upForce = 1f;
    [SerializeField] float sidesForce = 1f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddRelativeForce(Vector3.up * upForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(Vector3.right);
        }
    }

    private void ApplyRotation(Vector3 sideRotation)
    {
        rigidbody.freezeRotation = true;
        transform.Rotate(sideRotation * sidesForce * Time.deltaTime);
        rigidbody.freezeRotation = false;
    }
}
