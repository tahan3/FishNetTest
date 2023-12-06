using System;
using UnityEngine;
using Zenject;

namespace InputHandlers
{
    public interface IInputHandler
    {
        public Vector3 InputValues { get; }
        public void HandleInput();
    }
}