using Zenject;

namespace Installers
{
    public abstract class APlayerInstaller : Installer
    {
        public override void InstallBindings()
        {
            InitPrefabs();
            InitInputs();
            InitMovement();
            InitRotation();
            InitAnimations();
            InitPlayersHandler();
        }

        protected abstract void InitPrefabs();

        protected abstract void InitPlayersHandler();

        protected abstract void InitAnimations();

        protected abstract void InitRotation();

        protected abstract void InitMovement();

        protected abstract void InitInputs();
    }
}