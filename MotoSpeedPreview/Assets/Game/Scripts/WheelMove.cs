using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelMove : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private WheelJoint2D _wheel;
    private JointMotor2D _motor;

    private void Start()
    {
        _wheel = GetComponentInParent<WheelJoint2D>();
        _motor = _wheel.motor;
    }

    // Update is called once per frame
    private void Update()
    {
        float hForce = Input.GetAxis("Horizontal");

        _motor.motorSpeed = speed * hForce;

        _wheel.motor = _motor;
    }
}