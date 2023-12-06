using StateMachine;

namespace UISystem.Controllers
{
    public interface IUIController
    {
        UISwitcher UISwitcher { get; set; }
        void Enter();
        void Exit();
    }
}