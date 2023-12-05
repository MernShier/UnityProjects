using UnityEngine;

namespace CombatSystem.Strategy
{
    public class AttackType3 : IAttackStrategy
    {
        private readonly int _attack1;

        public AttackType3(string attackTriggerName)
        {
            _attack1 = Animator.StringToHash(attackTriggerName);
        }
        
        public void Attack(Animator animator)
        {
            animator.SetTrigger(_attack1);
        }
    }
}