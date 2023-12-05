using CombatSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputHandler : MonoBehaviour
    {
        private AttackPerformer _attackPerformer;

        public void Construct(AttackPerformer attackPerformer)
        {
            _attackPerformer = attackPerformer;
        }
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                _attackPerformer.PerformAttack();
            }
        }
    }
}