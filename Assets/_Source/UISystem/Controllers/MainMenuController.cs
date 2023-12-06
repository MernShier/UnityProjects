using Core.UISystem;
using EventSystem.Data;
using ResourceSystem;
using ResourceSystem.Data;
using StateMachine;
using UnityEngine;

namespace UISystem.Controllers
{
    public class MainMenuController : IUIController, IGameEventListener
    {
        private MainMenuView _mainMenuView;
        private ResourceStorage _resourceStorage;
        private ResourceView _woodResourceView;
        private ResourceView _ironResourceView;
        private ResourceView _goldResourceView;
        private EventSO _eventSO;

        public UISwitcher UISwitcher { get; set; }

        public MainMenuController(MainMenuView menuView, ResourceStorage resourceStorage, UISwitcher uiSwitcher, EventSO eventSO)
        {
            _mainMenuView = menuView;
            _resourceStorage = resourceStorage;
            UISwitcher = uiSwitcher;

            _mainMenuView.MainMenuButton.onClick.AddListener(ChangeState);
            _mainMenuView.ResetButton.onClick.AddListener(Reset);

            _woodResourceView = Object.Instantiate(_mainMenuView.Resource, _mainMenuView.Group);
            _ironResourceView = Object.Instantiate(_mainMenuView.Resource, _mainMenuView.Group);
            _goldResourceView = Object.Instantiate(_mainMenuView.Resource, _mainMenuView.Group);

            _woodResourceView.ResourceName.text = ResourceTypes.Crystals.ToString();
            _ironResourceView.ResourceName.text = ResourceTypes.Dust.ToString();
            _goldResourceView.ResourceName.text = ResourceTypes.Wood.ToString();

            _eventSO = eventSO;
            _eventSO.RegisterObserver(this);

            SetText();
        }

        public void Enter()
        {
            _mainMenuView.MainMenuPanel.SetActive(true);
            SetText();
        }

        public void Exit()
        {
            _mainMenuView.MainMenuPanel.SetActive(false);
        }

        public void Notify()
        {
            _resourceStorage.Resources[ResourceTypes.Crystals] = 0;
            _resourceStorage.Resources[ResourceTypes.Dust] = 0;
            _resourceStorage.Resources[ResourceTypes.Wood] = 0;

            SetText();
        }

        private void Reset()
        {
            _eventSO.Notify();
        }

        private void SetText()
        {
            _woodResourceView.ResourceAmount.text = _resourceStorage.Resources[ResourceTypes.Crystals].ToString();
            _ironResourceView.ResourceAmount.text = _resourceStorage.Resources[ResourceTypes.Dust].ToString();
            _goldResourceView.ResourceAmount.text = _resourceStorage.Resources[ResourceTypes.Wood].ToString();
        }

        private void ChangeState()
        {
            UISwitcher.ChangeState(this);
        }
    }
}