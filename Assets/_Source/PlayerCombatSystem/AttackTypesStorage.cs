using System;
using System.Collections.Generic;
using CombatSystem.Strategy;

namespace CombatSystem
{
    public class AttackTypesStorage
    {
        public readonly Dictionary<Type, IAttackStrategy> AttackStrategies = new();

        public AttackTypesStorage(AttackType1 attackType1, AttackType2 attackType2, AttackType3 attackType3)
        {
            AttackStrategies.Add(typeof(AttackType1), attackType1);
            AttackStrategies.Add(typeof(AttackType2), attackType2);
            AttackStrategies.Add(typeof(AttackType3), attackType3);
        }
    }
}