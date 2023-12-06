using UnityEngine;
using Zenject;

namespace Core.Installers
{
    public class MainInstaller : MonoInstaller
    {
        [SerializeField] private Bootstrapper bootstrapper;
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<Bootstrapper>().AsSingle().NonLazy();
        }
    }
}