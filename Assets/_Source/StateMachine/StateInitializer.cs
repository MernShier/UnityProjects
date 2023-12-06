using EventSystem.Data;
using ResourceSystem;
using UISystem;
using UISystem.Controllers;

namespace StateMachine
{
    public class StateInitializer
    {
        public IUIController mainMenuState { get; private set; }
        public IUIController addMenuState { get; private set; }
        public IUIController removeMenuState { get; private set; }

        public StateInitializer(MainMenuView menuView, AddMenuView addView, RemoveMenuView removeView, ResourceStorage resourceStorage, UISwitcher uiSwitcher, EventSO resetEventSO, EventSO addEventSO, EventSO removeEventSO)
        {
            mainMenuState = new MainMenuController(menuView, resourceStorage, uiSwitcher, resetEventSO);
            addMenuState = new AddMenuController(addView, resourceStorage, uiSwitcher, addEventSO);
            removeMenuState = new RemoveMenuController(removeView, resourceStorage, uiSwitcher, removeEventSO);
        }
    }
}