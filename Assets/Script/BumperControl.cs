using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperControl : MonoBehaviour
{
    public Collider bola;
    public float multiplier;

    private Animator animator;

    private void Start()
    {
        animator= GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolarig = bola.GetComponent<Rigidbody>();
            bolarig.velocity *= multiplier;

            //animasi
            animator.SetTrigger("hit");
        }
    }
}
