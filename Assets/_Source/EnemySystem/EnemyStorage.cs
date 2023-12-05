using System;
using System.Collections.Generic;
using EnemySystem.Enemies;

namespace EnemySystem
{
    public class EnemyStorage
    {
        public readonly Dictionary<Type, Enemy> Enemies = new();

        public EnemyStorage(Enemy1 enemy1, Enemy2 enemy2, Enemy3 enemy3)
        {
            Enemies.Add(typeof(Enemy1), enemy1);
            Enemies.Add(typeof(Enemy2), enemy2);
            Enemies.Add(typeof(Enemy3), enemy3);
        }
    }
}