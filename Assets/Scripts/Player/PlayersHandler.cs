using Animations;
using Movement;
using Rotation;
using Zenject;

namespace Player
{
    public class PlayersHandler : ITickable, IFixedTickable
    {
        private IAnimationsHandler _animationsHandler;
        private IMovementHandler _movementHandler;
        private IRotationHandler _rotationHandler;

        public PlayersHandler(IAnimationsHandler animationsHandler, 
            IMovementHandler movementHandler,
            IRotationHandler rotationHandler)
        {
            _animationsHandler = animationsHandler;
            _movementHandler = movementHandler;
            _rotationHandler = rotationHandler;
        }

        public virtual void FixedTick()
        {
            _movementHandler.HandleMovement();
            _rotationHandler.HandleRotation();
        }
        
        public virtual void Tick()
        {
            _animationsHandler.HandleAnimations();
        }
    }
}