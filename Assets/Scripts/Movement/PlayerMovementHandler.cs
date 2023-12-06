using Configs;
using InputHandlers;
using UnityEngine;

namespace Movement
{
    public class PlayerMovementHandler : IMovementHandler
    {
        private IInputHandler _inputHandler;
        private Rigidbody _rigidbody;

        private float _moveSpeed;
        
        public PlayerMovementHandler(IInputHandler inputHandler, float moveSpeed, Rigidbody rigidbody)
        {
            _inputHandler = inputHandler;
            _moveSpeed = moveSpeed;
            _rigidbody = rigidbody;
        }

        public void HandleMovement()
        {
            _rigidbody.velocity = _inputHandler.InputValues.normalized * _moveSpeed;
        }
    }
}