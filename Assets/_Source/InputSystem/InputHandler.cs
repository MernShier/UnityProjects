using System;
using CombatSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputHandler : MonoBehaviour
    {
        [SerializeField] private KeyCode attackKeyCode;
        public event Action OnAttackKeyCodePressed; 
        private AttackPerformer _attackPerformer;

        public void Construct(AttackPerformer attackPerformer)
        {
            _attackPerformer = attackPerformer;
        }
        
        private void Update()
        {
            if (Input.GetKeyDown(attackKeyCode))
            {
                _attackPerformer.PerformAttack();
                OnAttackKeyCodePressed?.Invoke();
            }
        }
    }
}