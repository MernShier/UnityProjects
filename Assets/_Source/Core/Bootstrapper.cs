using System;
using System.Collections.Generic;
using CombatSystem;
using CombatSystem.Strategy;
using EnemySystem;
using EnemySystem.Enemies;
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
        [SerializeField] private Enemy1 enemy1;
        [SerializeField] private Enemy2 enemy2;
        [SerializeField] private Enemy3 enemy3;
        private EnemyChanger _enemyChanger;
        private EnemyStorage _enemyStorage;
        private AttackPerformer _attackPerformer;
        private AttackTypesStorage _attackTypesStorage;
        private AttackType1 _attackType1;
        private AttackType2 _attackType2;
        private AttackType3 _attackType3;

        private void Awake()
        {
            InitializePlayerCombatSystem();
            _enemyStorage = new EnemyStorage(enemy1, enemy2, enemy3);
            _enemyChanger = new EnemyChanger(_enemyStorage);
            attackTypeView.Construct(_attackPerformer, _enemyChanger);
            inputHandler.Construct(_attackPerformer);
        }

        private void InitializePlayerCombatSystem()
        {
            _attackType1 = new AttackType1("Attack1");
            _attackType2 = new AttackType2("Attack2");
            _attackType3 = new AttackType3("Attack3");
            _attackTypesStorage = new AttackTypesStorage(_attackType1, _attackType2, _attackType3);
            _attackPerformer = new AttackPerformer(_attackTypesStorage, playerAnimator);
        }
    }
}