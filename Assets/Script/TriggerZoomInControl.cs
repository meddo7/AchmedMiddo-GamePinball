using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomInControl : MonoBehaviour
{
    public Collider bola;
    public CameraControll cameraControll;
    public float legth;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            cameraControll.FollowTarget(bola.transform, legth);
        }
    }
}
