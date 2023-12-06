using InputHandlers;
using UnityEngine;

namespace Rotation
{
    public class PlayerRotationHandler : IRotationHandler
    {
        private IInputHandler _inputHandler;
        private Rigidbody _rigidbody;

        public PlayerRotationHandler(IInputHandler inputHandler, Rigidbody rigidbody)
        {
            _inputHandler = inputHandler;
            _rigidbody = rigidbody;
        }

        public virtual void HandleRotation()
        {
            _rigidbody.MoveRotation(Quaternion.LookRotation(_inputHandler.InputValues.normalized,
                Vector3.up));
        }
    }
}