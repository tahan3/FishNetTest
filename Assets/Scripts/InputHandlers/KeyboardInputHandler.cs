using UnityEngine;

namespace InputHandlers
{
    public class KeyboardInputHandler : IInputHandler
    {
        public Vector3 InputValues => _input;
        
        private Vector3 _input = Vector3.zero;

        public void HandleInput()
        {
            _input.x = Input.GetAxis("Horizontal");
            _input.z = Input.GetAxis("Vertical");
        }
    }
}