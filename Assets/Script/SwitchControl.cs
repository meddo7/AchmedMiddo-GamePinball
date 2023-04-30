using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControl : MonoBehaviour
{
    private enum SwitchStates
    {
        off,
        on,
        Blink
    }

    public Collider bola;
    public Material on;
    public Material off;

    private SwitchStates state;
    private Renderer renderer;

    private void Start()
    {
        renderer= GetComponent<Renderer>();
        Set(false);

        StartCoroutine(BlinkTimeStart(5));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Toggle();
        }
    }

    private void Set(bool Active)
    {

        if (Active == true)
        {
            state = SwitchStates.on;
            renderer.material = on;
            StopAllCoroutines();
        }
        else
        {   
            state = SwitchStates.off;  
            renderer.material = off;
            StartCoroutine(BlinkTimeStart(5));
        }
    }

    private void Toggle()
    {
        if (state == SwitchStates.on)
        {
            Set(false);
        }
        else
        {
            Set(true);
        }
    }

    private IEnumerator Blink(int times)
    {
        state = SwitchStates.Blink;

        int blinkTimes = times * 2;

        for (int i = 0; i < blinkTimes; i++)
        {
            renderer.material = on;
            yield return new WaitForSeconds(0.5f);
            renderer.material = off;
            yield return new WaitForSeconds(0.5f);
        }

        state= SwitchStates.off;
        StartCoroutine(BlinkTimeStart(5));
    }

    private IEnumerator BlinkTimeStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
