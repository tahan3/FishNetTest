using System;
using UnityEngine;
using Zenject;

namespace InputHandlers
{
    public class TickKeyboardInputHandlerHandler : KeyboardInputHandler, ITickable
    {
        public void Tick()
        {
            HandleInput();
        }
    }
}