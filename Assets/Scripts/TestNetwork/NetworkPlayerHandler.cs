using FishNet.Object;
using UnityEngine;

namespace TestNetwork
{
    [RequireComponent(typeof(NetworkObject))]
    public class NetworkPlayerHandler : PlayerHandler
    {
        private NetworkObject _netObj;

        protected override void Start()
        {
            base.Start();
            
            _netObj = GetComponent<NetworkObject>();
        }

        protected override void FixedUpdate()
        {
            if (_netObj.IsOwner)
            {
                base.FixedUpdate();
            }
        }
        
        protected override void Update()
        {
            if (_netObj.IsOwner)
            {
                base.Update();
            }
        }
    }
}