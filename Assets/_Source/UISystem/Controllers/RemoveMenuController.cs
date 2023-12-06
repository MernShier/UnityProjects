using System.Collections.Generic;
using EventSystem.Data;
using ResourceSystem;
using ResourceSystem.Data;
using StateMachine;

namespace UISystem.Controllers
{
    public class RemoveMenuController : IUIController, IGameEventListener
    {
        private RemoveMenuView _removeMenuView;
        private ResourceStorage _resourceStorage;

        private EventSO _eventSO;

        public UISwitcher UISwitcher { get; set; }

        public RemoveMenuController(RemoveMenuView removeMenuView, ResourceStorage resourceStorage, UISwitcher uiSwitcher, EventSO eventSO)
        {
            _removeMenuView = removeMenuView;
            _resourceStorage = resourceStorage;
            UISwitcher = uiSwitcher;

            _removeMenuView.RemoveMenuButton.onClick.AddListener(ChangeState);
            _removeMenuView.RemoveButton.onClick.AddListener(Remove);

            _eventSO = eventSO;
            _eventSO.RegisterObserver(this);

            _removeMenuView.DropDown.AddOptions(new List<string> { ResourceTypes.Crystals.ToString(), ResourceTypes.Dust.ToString(), ResourceTypes.Wood.ToString()});
        }

        public void Enter()
        {
            _removeMenuView.RemoveMenuPanel.SetActive(true);
            SetText();
        }

        public void Exit()
        {
            _removeMenuView.RemoveMenuPanel.SetActive(false);
        }

        public void Notify()
        {
            _resourceStorage.Resources[(ResourceTypes)_removeMenuView.DropDown.value] -= int.Parse(_removeMenuView.InputField.text);

            if (_resourceStorage.Resources[(ResourceTypes)_removeMenuView.DropDown.value] < 0)
                _resourceStorage.Resources[(ResourceTypes)_removeMenuView.DropDown.value] = 0;

            SetText();
        }

        private void Remove()
        {
            _eventSO.Notify();
        }

        private void SetText()
        {
            _removeMenuView.DropDown.value = 0;
            _removeMenuView.InputField.text = "";
        }

        private void ChangeState()
        {
            UISwitcher.ChangeState(this);
        }
    }
}