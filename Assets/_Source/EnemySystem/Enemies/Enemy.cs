using System;
using UnityEngine;

namespace EnemySystem.Enemies
{
    [RequireComponent(typeof(Animator))]
    public abstract class Enemy : MonoBehaviour
    {
        [SerializeField] private string attackTriggerName;
        private Animator _animator;
        private int _attackTrigger;

        protected virtual void Awake()
        {
            _animator = GetComponent<Animator>();
            _attackTrigger = Animator.StringToHash(attackTriggerName);
        }

        protected void Attack()
        {
            _animator.SetTrigger(_attackTrigger);
        }
    }
}