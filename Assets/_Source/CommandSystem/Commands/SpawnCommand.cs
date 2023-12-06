using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace CommandSystem.Commands
{
    public class SpawnCommand : ICommand
    {
        private GameObject _objectToSpawn;
        private readonly List<GameObject> _spawnedObjects = new();

        public SpawnCommand(GameObject objectToSpawn)
        {
            _objectToSpawn = objectToSpawn;
        }

        public void Invoke(Vector2 position)
        {
            _spawnedObjects.Add(Object.Instantiate(_objectToSpawn, position, quaternion.identity));
        }

        public void Undo()
        {
            Object.Destroy(_spawnedObjects[^1]);
            _spawnedObjects.RemoveAt(_spawnedObjects.Count-1);
        }
    }
}