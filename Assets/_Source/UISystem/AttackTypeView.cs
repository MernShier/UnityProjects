using System;
using System.Collections.Generic;
using CombatSystem;
using CombatSystem.Strategy;
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

        public void Construct(AttackPerformer attackPerformer)
        {
            _attackPerformer = attackPerformer;
            BindAttackTypeButtons();
        }

        private void BindAttackTypeButtons()
        {
            attackTypeButtonsView.AttackType1Button.onClick.AddListener(
                () => _attackPerformer.SetAttackStrategy<AttackType1>());
            attackTypeButtonsView.AttackType2Button.onClick.AddListener(
                () => _attackPerformer.SetAttackStrategy<AttackType2>());
            attackTypeButtonsView.AttackType3Button.onClick.AddListener(
                () => _attackPerformer.SetAttackStrategy<AttackType3>());
        }
    }
}