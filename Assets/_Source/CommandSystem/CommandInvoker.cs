using System.Collections.Generic;
using CommandSystem.Commands;
using UnityEngine;

namespace CommandSystem
{
    public class CommandInvoker
    {
        private const int INVOKED_COMMANDS_STORAGE_LIMIT = 15;
        private readonly List<ICommand> _executedCommands = new ();
        private readonly List<(ICommand, Vector2)> _storedCommands = new ();

        public void StoreCommand(ICommand command, Vector2 vector2)
        {
            _storedCommands.Add(new (command, vector2));
        }

        public void ExecuteStoredCommands()
        {
            foreach (var commandVector2 in _storedCommands)
            {
                Execute(commandVector2.Item1, commandVector2.Item2);
            }
        }

        public void Execute(ICommand command, Vector2 position)
        {
            command.Invoke(position);

            if (_executedCommands.Count >= INVOKED_COMMANDS_STORAGE_LIMIT)
            {
                _executedCommands.RemoveAt(0);
            }
            _executedCommands.Add(command);
        }

        public void Undo()
        {
            _executedCommands[^1]?.Undo();
            _executedCommands.Remove(_executedCommands[^1]);
        }
    }
}