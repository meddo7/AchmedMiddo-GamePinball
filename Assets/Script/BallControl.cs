using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float maxSpeed;

    private Rigidbody Rigidbody;

    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Rigidbody.velocity.magnitude > maxSpeed)
        {
           Rigidbody.velocity=  Rigidbody.velocity.normalized* maxSpeed;
        }
    }
}
