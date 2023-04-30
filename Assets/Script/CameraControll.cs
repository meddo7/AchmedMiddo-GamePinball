using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public float returnTime;
    public float followSpeed;

    public Transform target;
    public float legth;

    private Vector3 defaultPosition;

    public bool hasTarget { get { return target != null; } }
    
    private void Start()
    {
        defaultPosition = transform.position;
        target = null;
    }

    private void Update()
    {
        if (hasTarget)
        {
            Vector3 targetToCamera = transform.rotation * -Vector3.forward;
            Vector3 targetPosition = target.position + (targetToCamera * legth);

            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }


    public void FollowTarget(Transform targetTransform, float targetLegth)
    {
        StopAllCoroutines();
        target= targetTransform;
        legth = targetLegth;
    }

    public void goBackDefault()
    {
        target = null;

        StopAllCoroutines();
        StartCoroutine(MovePosition(defaultPosition, returnTime));
    }

    private IEnumerator MovePosition(Vector3 target, float time)
    {
        float timer = 0;
        Vector3 start = transform.position;

        while (timer < time)
        {
            transform.position = Vector3.Lerp(start, target, Mathf.SmoothStep(0.0f, 1.0f, timer/time));

            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        transform.position = target;
    }
}
