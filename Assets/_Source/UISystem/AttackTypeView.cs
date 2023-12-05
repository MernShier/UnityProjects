using System;
using System.Collections.Generic;
using CombatSystem;
using CombatSystem.Strategy;
using EnemySystem;
using EnemySystem.Enemies;
using UISystem.Data;
using UnityEngine;
using UnityEngine.UI;

namespace UISystem
{
    public class AttackTypeView : MonoBehaviour
    {
        [SerializeField] private AttackTypeButtonsView attackTypeButtonsView;
        private AttackTypesStorage _attackTypesStorage;
        private AttackPerformer _attackPerformer;
        private EnemyChanger _enemyChanger;

        public void Construct(AttackPerformer attackPerformer, EnemyChanger enemyChanger)
        {
            _attackPerformer = attackPerformer;
            _enemyChanger = enemyChanger;
            BindAttackTypeButtons();
        }

        private void BindAttackTypeButtons()
        {
            attackTypeButtonsView.AttackType1Button.onClick.AddListener(
                () =>
                {
                    _attackPerformer.SetAttackStrategy<AttackType1>();
                    _enemyChanger.SetCurrentEnemy<Enemy1>();
                });
            attackTypeButtonsView.AttackType2Button.onClick.AddListener(
                () =>
                {
                    _attackPerformer.SetAttackStrategy<AttackType2>();
                    _enemyChanger.SetCurrentEnemy<Enemy2>();
                });
            attackTypeButtonsView.AttackType3Button.onClick.AddListener(
                () =>
                {
                    _attackPerformer.SetAttackStrategy<AttackType3>();
                    _enemyChanger.SetCurrentEnemy<Enemy3>();
                });
        }
    }
}