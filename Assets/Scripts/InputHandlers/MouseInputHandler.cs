using UnityEngine;

namespace InputHandlers
{
    public class MouseInputHandler : IInputHandler
    {
        public Vector3 InputValues => _mousePosition;

        private Vector3 _mousePosition;
        private Plane _plane = new Plane(Vector3.up, 0);
        private readonly Camera _camera = Camera.main;
        
        public void HandleInput()
        {
            float distance;
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (_plane.Raycast(ray, out distance))
            {
                _mousePosition = ray.GetPoint(distance);
            }
        }
    }
}