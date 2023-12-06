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
    public class PlayerInstaller : APlayerInstaller
    {
        protected IInputHandler KeyboardInput;
        protected IInputHandler MouseInput;
        protected IRotationHandler Rotation;
        protected IMovementHandler Movement;
        protected IAnimationsHandler Animations;
        protected PlayersHandler PlayersHandler;

        protected GameObject PlayerPrefab;
        
        [Inject] protected PlayerConfig PlayerConfig;
        
        protected override void InitPrefabs()
        {
            PlayerPrefab = Container.InstantiatePrefab(PlayerConfig.playerPrefab);
        }
        
        protected override void InitInputs()
        {
            KeyboardInput = new TickKeyboardInputHandlerHandler();
            MouseInput = new TickMouseInputHandler();

            Container.BindInterfacesAndSelfTo<TickKeyboardInputHandlerHandler>().FromInstance(KeyboardInput);
            Container.BindInterfacesAndSelfTo<TickMouseInputHandler>().FromInstance(MouseInput);
        }

        protected override void InitAnimations()
        {
            Animations = new PlayerAnimationsHandler(KeyboardInput, PlayerPrefab.GetComponent<Animator>());
        }

        protected override void InitRotation()
        {
            Rotation = new PlayerRotationHandler(MouseInput, PlayerPrefab.GetComponent<Rigidbody>());
        }

        protected override void InitMovement()
        {
            Movement = new PlayerMovementHandler(KeyboardInput, PlayerConfig.moveSpeed, PlayerPrefab.GetComponent<Rigidbody>());
        }
        
        protected override void InitPlayersHandler()
        {
            PlayersHandler = new PlayersHandler(Animations, Movement, Rotation);
            Container.BindInterfacesAndSelfTo<PlayersHandler>().FromInstance(PlayersHandler);
        }
    }
}
