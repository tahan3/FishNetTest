using Animations;
using Configs;
using InputHandlers;
using Movement;
using Rotation;
using UnityEngine;
using Zenject;

namespace TestNetwork
{
    public class PlayerHandler : APlayerHandler
    {
        [SerializeField] private float moveSpeed;
        
        protected virtual void Start()
        {
            var rb = GetComponent<Rigidbody>();

            KeyboardInput = new KeyboardInputHandler();
            MouseInput = new MouseInputHandler();
            
            AnimationsHandler = new PlayerAnimationsHandler(KeyboardInput, GetComponent<Animator>());
            MovementHandler = new PlayerMovementHandler(KeyboardInput, moveSpeed, rb);
            RotationHandler = new PlayerRotationHandler(MouseInput, rb);
        }
    }
}