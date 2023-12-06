using System;
using Animations;
using InputHandlers;
using Movement;
using Rotation;
using UnityEngine;

namespace TestNetwork
{
    [RequireComponent(typeof(Rigidbody), typeof(Animator))]
    public abstract class APlayerHandler : MonoBehaviour
    {
        protected IAnimationsHandler AnimationsHandler;
        protected IMovementHandler MovementHandler;
        protected IRotationHandler RotationHandler;
        protected IInputHandler KeyboardInput;
        protected IInputHandler MouseInput;
        
        protected virtual void FixedUpdate()
        {
            MovementHandler.HandleMovement();
            RotationHandler.HandleRotation();
        }

        protected virtual void Update()
        {
            KeyboardInput.HandleInput();
            MouseInput.HandleInput();
            AnimationsHandler.HandleAnimations();
        }
    }
}