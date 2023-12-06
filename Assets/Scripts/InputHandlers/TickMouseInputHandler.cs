using System;
using UnityEngine;
using Zenject;

namespace InputHandlers
{
    public class TickMouseInputHandler : MouseInputHandler, ITickable
    {
        public void Tick()
        {
            HandleInput();
        }
    }
}