using CommandSystem;
using CommandSystem.Commands;
using UnityEngine;

namespace InputSystem
{
    public class InputHandler : MonoBehaviour
    {
        private Camera _mainCamera;
        private CommandInvoker _commandInvoker;
        private MoveCommand _moveCommand;
        private SpawnCommand _spawnCommand;

        public void Construct(Camera mainCamera, CommandInvoker commandInvoker,
            MoveCommand moveCommand, SpawnCommand spawnCommand)
        {
            _mainCamera = mainCamera;
            _commandInvoker = commandInvoker;
            _moveCommand = moveCommand;
            _spawnCommand = spawnCommand;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                _commandInvoker.Execute(_moveCommand, _mainCamera.ScreenToWorldPoint(Input.mousePosition));
            }
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                _commandInvoker.StoreCommand(_spawnCommand, _mainCamera.ScreenToWorldPoint(Input.mousePosition));
            }
            else if (Input.GetKeyDown(KeyCode.Mouse2))
            {
                _commandInvoker.Undo();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                _commandInvoker.ExecuteStoredCommands();
            }
        }
    }
}