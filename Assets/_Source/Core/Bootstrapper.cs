using System;
using System.Collections.Generic;
using CombatSystem;
using CombatSystem.Strategy;
using InputSystem;
using UISystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private InputHandler inputHandler;
        [SerializeField] private Animator playerAnimator;
        [SerializeField] private AttackTypeView attackTypeView;
        private AttackPerformer _attackPerformer;
        private AttackTypesStorage _attackTypesStorage;
        private AttackType1 _attackType1;
        private AttackType2 _attackType2;
        private AttackType3 _attackType3;

        private void Awake()
        {
            _attackType1 = new AttackType1("Attack1");
            _attackType2 = new AttackType2("Attack2");
            _attackType3 = new AttackType3("Attack3");
            _attackTypesStorage = new AttackTypesStorage(_attackType1, _attackType2, _attackType3);
            _attackPerformer = new AttackPerformer(_attackTypesStorage, playerAnimator);
            attackTypeView.Construct(_attackPerformer);
            inputHandler.Construct(_attackPerformer);
        }
    }
}