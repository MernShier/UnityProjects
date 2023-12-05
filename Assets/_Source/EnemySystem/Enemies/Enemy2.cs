using System.Collections;
using ShootingSystem;
using UnityEngine;

namespace EnemySystem.Enemies
{
    public class Enemy2 : Enemy
    {
        [SerializeField] private Projectile projectilePrefab;
        [SerializeField] private float shootDelay;
        
        private void OnEnable()
        {
            StartCoroutine(Shoot());
        }
        
        private IEnumerator Shoot()
        {
            while (true)
            {
                yield return new WaitForSeconds(shootDelay);
                Instantiate(projectilePrefab, transform);
            }
        }
    }
}