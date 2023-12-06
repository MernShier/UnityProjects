using UnityEngine;

namespace CommandSystem.Commands
{
    public interface ICommand
    {
        void Invoke(Vector2 position);
        void Undo();
    }
}