using System;
using UnityEngine;

namespace Game.Scripts
{
    public class WheelMove : MonoBehaviour
    {
        [SerializeField] private float speed;
        
        private WheelJoint2D _wheel;
        private JointMotor2D _motor;

        public bool movingRight;
        
        private void Start()
        {
            _wheel = GetComponentInParent<WheelJoint2D>();
            _motor = _wheel.motor;
        }

        private void FixedUpdate()
        {
            if (movingRight && Input.GetMouseButton(0))
            {
                _motor.motorSpeed = speed * -1;

                _wheel.motor = _motor;
            }
            else if (!movingRight && Input.GetMouseButton(0))
            {
                _motor.motorSpeed = speed * 1;

                _wheel.motor = _motor;
            }
        }
    }
}