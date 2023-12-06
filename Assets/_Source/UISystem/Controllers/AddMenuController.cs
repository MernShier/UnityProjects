using System.Collections.Generic;
using EventSystem.Data;
using ResourceSystem;
using ResourceSystem.Data;
using StateMachine;

namespace UISystem.Controllers
{
    public class AddMenuController : IUIController, IGameEventListener
    {
        private AddMenuView _addMenuView;
        private ResourceStorage _resourceStorage;

        private EventSO _eventSO;

        public UISwitcher UISwitcher { get; set; }

        public AddMenuController(AddMenuView addMenuView, ResourceStorage resourceStorage, UISwitcher uiSwitcher, EventSO eventSO)
        {
            _addMenuView = addMenuView;
            _resourceStorage = resourceStorage;
            UISwitcher = uiSwitcher;

            _addMenuView.AddMenuButton.onClick.AddListener(ChangeState);

            _addMenuView.RemoveButton.onClick.AddListener(Add);

            _eventSO = eventSO;
            _eventSO.RegisterObserver(this);

            _addMenuView.DropDown.AddOptions(new List<string> { ResourceTypes.Crystals.ToString(), ResourceTypes.Dust.ToString(), ResourceTypes.Wood.ToString() });
        }

        public void Enter()
        {
            _addMenuView.AddMenuPanel.SetActive(true);
            SetText();
        }

        public void Exit()
        {
            _addMenuView.AddMenuPanel.SetActive(false);
        }

        public void Notify()
        {
            _resourceStorage.Resources[(ResourceTypes)_addMenuView.DropDown.value] += int.Parse(_addMenuView.InputField.text);

            SetText();
        }

        private void Add()
        {
            _eventSO.Notify();
        }

        private void SetText()
        {
            _addMenuView.DropDown.value = 0;
            _addMenuView.InputField.text = "";
        }

        private void ChangeState()
        {
            UISwitcher.ChangeState(this);
        }
    }
}