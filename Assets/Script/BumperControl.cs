using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BumperControl : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public float score;

    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;

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

            //play sfx
            audioManager.PlaySFX(collision.transform.position);

            //play vfx
            vfxManager.PlayVFX(collision.transform.position);

            scoreManager.Addscore(score);

        }
    }
}
