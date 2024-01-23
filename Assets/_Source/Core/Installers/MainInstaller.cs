using SaveSystem.Savers;
using ScoreSystem;
using ScoreSystem.Data;
using TimerSystem;
using UnityEngine;
using Zenject;

namespace Core.Installers
{
    public class MainInstaller : MonoInstaller
    {
        [SerializeField] private ScoreSettings scoreSettings;
        [SerializeField] private Timer timer;
        
        public override void InstallBindings()
        {
            BindScoreSystem();
            BindTimerSystem();
            BindSaveSystem();
        }

        private void BindScoreSystem()
        {
            Container.BindInstance(scoreSettings).AsSingle().NonLazy();
            Container.Bind<Score>().AsSingle().NonLazy();
        }

        private void BindTimerSystem()
        {
            Container.BindInstance(timer).AsSingle().NonLazy();
        }

        private void BindSaveSystem()
        {
            Container.Bind<JsonSaver>().AsSingle().NonLazy();
            Container.Bind<PlayerPrefsSaver>().AsSingle().NonLazy();
        }
    }
}