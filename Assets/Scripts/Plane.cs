using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    private Rigidbody rb;

    private Rotation3DComplex r3D;

    private Vector3 movement;

    //public int Heart = 3;


    void Start()
    {
        rb = GetComponent<Rigidbody>();

        r3D = GetComponent<Rotation3DComplex>();
    }

    void Update()
    {
        movement = new Vector3(Input.GetAxisRaw("Vertical"), 0, Input.GetAxisRaw("Horizontal"));
        r3D.angle = new Vector3(movement.x * -35, 0, movement.z * -35);

    }

    void FixedUpdate()
    {
        Vector3 n = movement.normalized;

        rb.velocity = new Vector3(movement.z, movement.x, 0);
    }

}
