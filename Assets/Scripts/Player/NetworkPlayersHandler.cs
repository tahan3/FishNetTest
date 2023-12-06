using Animations;
using FishNet;
using FishNet.Object;
using Movement;
using Rotation;
using UnityEngine;

namespace Player
{
    public class NetworkPlayersHandler : PlayersHandler
    {
        private NetworkObject _networkObject;
        
        public NetworkPlayersHandler(NetworkObject networkObject, IAnimationsHandler animationsHandler, IMovementHandler movementHandler,
            IRotationHandler rotationHandler) : base(animationsHandler, movementHandler, rotationHandler)
        {
            _networkObject = networkObject;
        }

        public override void Tick()
        {
            if (_networkObject.IsOwner)
            {
                base.Tick();
            }
        }

        public override void FixedTick()
        {
            if (_networkObject.IsOwner)
            {
                base.FixedTick();
            }
        }
    }
}