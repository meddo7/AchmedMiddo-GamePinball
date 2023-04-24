using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{
    public KeyCode input;

    private float targetPressed;
    private float targetReleased;
    private HingeJoint hinge;

    void Start()
    {
        hinge= GetComponent<HingeJoint>();
    }

    void Update()
    {
        ReadInput();

        targetPressed = hinge.limits.max;
        targetReleased = hinge.limits.min;
    }

    private void ReadInput()
    {
        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            
            jointSpring.targetPosition = targetPressed;
        }
        else
        {
            jointSpring.targetPosition= targetReleased;
        }

        hinge.spring = jointSpring;
    }
}
