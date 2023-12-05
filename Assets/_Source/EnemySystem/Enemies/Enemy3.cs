using InputSystem;
using UnityEngine;

namespace EnemySystem.Enemies
{
    public class Enemy3 : Enemy
    {
        [SerializeField] private InputHandler inputHandler;

        protected override void Awake()
        {
            base.Awake();
            inputHandler.OnAttackKeyCodePressed += Attack;
        }
    }
}
