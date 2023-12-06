using System.Collections.Generic;
using UnityEngine;

namespace CommandSystem.Commands
{
    public class MoveCommand : ICommand
    {
        private Transform _objectToMove;
        private List<Vector2> _previousObjectToMovePositions = new ();

        public MoveCommand(Transform objectToMove)
        {
            _objectToMove = objectToMove;
        }
        
        public void Invoke(Vector2 position)
        {
            _previousObjectToMovePositions.Add(_objectToMove.position);
            _objectToMove.position = position;
        }

        public void Undo()
        {
            _objectToMove.position = _previousObjectToMovePositions[^1];
            _previousObjectToMovePositions.RemoveAt(_previousObjectToMovePositions.Count-1);
        }
    }
}