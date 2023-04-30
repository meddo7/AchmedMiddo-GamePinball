using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LauncherControl : MonoBehaviour
{
    public Collider bola;
    public KeyCode input;
    public float maxTimeHold;
    public float maxforce;
    public Material HoldColor;
    public Material ReleaseColor;

    private bool isHold = false;
    private Renderer renderer;

    private void Start()
    {
        renderer= GetComponent<Renderer>();
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider == bola)
        {
            ReadInput(bola);    
        }
    }

    private void ReadInput(Collider collider)
    {
        if (Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(collider));
        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        isHold= true;
        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxforce, timeHold/maxTimeHold);

            yield return new WaitForEndOfFrame();

            timeHold += Time.deltaTime;
   
            if (timeHold >= maxTimeHold)
            {
                renderer.material = HoldColor;
            }

            



        }

        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false; 

        if(!isHold)
        {
            renderer.material= ReleaseColor;
        }
    }
}
