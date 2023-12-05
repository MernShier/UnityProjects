using UnityEngine;

namespace CombatSystem.Strategy
{
    public class AttackType1 : IAttackStrategy
    {
        private readonly int _attack1;

        public AttackType1(string attackTriggerName)
        {
            _attack1 = Animator.StringToHash(attackTriggerName);
        }
        
        public void Attack(Animator animator)
        {
            animator.SetTrigger(_attack1);
        }
    }
}