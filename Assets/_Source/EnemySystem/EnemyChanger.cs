using EnemySystem.Enemies;

namespace EnemySystem
{
    public class EnemyChanger
    {
        private Enemy _currentEnemy;
        private EnemyStorage _enemyStorage;

        public EnemyChanger(EnemyStorage enemyStorage)
        {
            _enemyStorage = enemyStorage;
        }
        
        public void SetCurrentEnemy<T>()
        {
            if (!_enemyStorage.Enemies.ContainsKey(typeof(T)))
            {
                return;
            }

            if (_currentEnemy)
            {
                _currentEnemy.gameObject.SetActive(false);
            }
            _currentEnemy = _enemyStorage.Enemies[typeof(T)];
            _currentEnemy.gameObject.SetActive(true);
        }
    }
}