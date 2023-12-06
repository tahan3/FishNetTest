using FishNet.Object;
using InputHandlers;
using UnityEngine;

namespace Animations
{
    public class NetworkPlayerAnimationsHandler : PlayerAnimationsHandler
    {
        private NetworkObject _networkObject;

        public NetworkPlayerAnimationsHandler(NetworkObject networkObject, IInputHandler inputHandler,
            Animator animator) : base(inputHandler, animator)
        {
            _networkObject = networkObject;
        }

        public override void HandleAnimations()
        {
            if (_networkObject.IsOwner)
            {
                base.HandleAnimations();
            }
        }
    }
}