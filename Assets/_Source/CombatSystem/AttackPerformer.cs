using CombatSystem.Strategy;
using UnityEngine;

namespace CombatSystem
{
    public class AttackPerformer
    {
        private IAttackStrategy _currentAttackStrategy;
        private AttackTypesStorage _attackTypesStorage;
        private Animator _animator;

        public AttackPerformer(AttackTypesStorage attackTypesStorage, Animator animator)
        {
            _attackTypesStorage = attackTypesStorage;
            _animator = animator;
        }
        
        public void SetAttackStrategy<T>()
        {
            if (!_attackTypesStorage.AttackStrategies.ContainsKey(typeof(T)))
            {
                return;
            }
            _currentAttackStrategy = _attackTypesStorage.AttackStrategies[typeof(T)];
        }


        public void PerformAttack()
        {
            _currentAttackStrategy.Attack(_animator);
        }
    }
}