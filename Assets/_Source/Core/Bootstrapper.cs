using CommandSystem;
using CommandSystem.Commands;
using InputSystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private Camera mainCamera;
        [SerializeField] private InputHandler inputHandler;
        [SerializeField] private GameObject gameObjectToMove;
        [SerializeField] private GameObject gameObjectToSpawn;

        private void Awake()
        {
            inputHandler.Construct(mainCamera,
                new CommandInvoker(), new MoveCommand(gameObjectToMove.transform), new SpawnCommand(gameObjectToSpawn));
        }
    }
}