using FishNet.Object;
using InputHandlers;
using UnityEngine;

namespace Rotation
{
    public class NetworkPlayerRotationHandler : PlayerRotationHandler
    {
        private NetworkObject _networkObject;
        
        public NetworkPlayerRotationHandler(NetworkObject networkObject, IInputHandler inputHandler, Rigidbody rigidbody) : base(inputHandler, rigidbody)
        {
            _networkObject = networkObject;
        }

        public override void HandleRotation()
        {
            if (_networkObject.IsOwner)
            {
                base.HandleRotation();
            }
        }
    }
}