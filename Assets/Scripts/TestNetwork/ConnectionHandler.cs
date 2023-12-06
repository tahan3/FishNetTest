using Configs;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using InputHandlers;
using Installers;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using Zenject;

namespace TestNetwork
{
    public class ConnectionHandler : MonoInstaller
    {
        [SerializeField] private PlayerConfig _playerConfig;
        
        private NetworkManager _networkManager;

        public override void InstallBindings()
        {
            _networkManager = InstanceFinder.NetworkManager;
            
            Container.Bind<PlayerConfig>().FromInstance(_playerConfig);
            
#if SERVER_BUILD
            _networkManager.ServerManager.StartConnection();
            _networkManager.SceneManager.OnClientLoadedStartScenes += InstantiatePlayerOnConnectToServer;
#else
            _networkManager.ClientManager.StartConnection();
#endif
        }
        
        private void InstantiatePlayerOnConnectToServer(NetworkConnection connection, bool asServer)
        {
            if (!asServer)
                return;

            var nob = _networkManager.GetPooledInstantiated(_playerConfig.playerPrefab, true);
            _networkManager.ServerManager.Spawn(nob, connection);
        }
    }
}
