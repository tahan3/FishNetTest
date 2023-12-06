using UnityEngine;
using Zenject;

namespace Installers
{
    public class TestPrefabInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Debug.Log("Kek");
        }
    }
}