using InputHandlers;
using UnityEngine;

namespace Animations
{
    public class PlayerAnimationsHandler : IAnimationsHandler
    {
        private IInputHandler _inputHandler;
        private Animator _animator;
        private Transform _target;
        
        private const float DampTime = 0.1f;
        
        public PlayerAnimationsHandler(IInputHandler inputHandler, Animator animator)
        {
            _inputHandler = inputHandler;
            _animator = animator;
            _target = animator.transform;
        }

        public virtual void HandleAnimations()
        {
            var vertical = Vector3.Dot(_inputHandler.InputValues.normalized, _target.forward);
            var horizontal = Vector3.Dot(_inputHandler.InputValues.normalized, _target.right);
            
            _animator.SetFloat(AnimationHash.Horizontal, horizontal, 
                DampTime, Time.deltaTime);
            _animator.SetFloat(AnimationHash.Vertical, vertical, 
                DampTime, Time.deltaTime);
        }
    }
}