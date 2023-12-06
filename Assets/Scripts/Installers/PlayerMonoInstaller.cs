using System;
using Animations;
using Configs;
using InputHandlers;
using Movement;
using Player;
using Rotation;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class PlayerMonoInstaller : MonoInstaller
    {
        [SerializeField] private PlayerConfig _playerConfig;
        [SerializeField] private GameObject _test;
        
        public override void InstallBindings()
        {
            BindConfigs();
            InstallPlayer();
            Container.InstantiatePrefab(_test);
        }

        public virtual void BindConfigs()
        {
            Container.Bind<PlayerConfig>().FromInstance(_playerConfig);
        }
        
        public virtual void InstallPlayer()
        {
            Container.Instantiate<PlayerInstaller>().InstallBindings();
        }
    }
}