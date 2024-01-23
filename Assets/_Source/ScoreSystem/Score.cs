using System;
using SaveSystem;

namespace ScoreSystem
{
    public class Score : ISaveDataUser
    {
        public event Action OnScoreChange;
        public float Value { get; private set; }

        public void Add(float value)
        {
            Value += value;
            OnScoreChange?.Invoke();
        }

        public void Save(SaveData saveData)
        {
            saveData.Score = Value;
        }

        public void Load(SaveData saveData)
        {
            Value = saveData.Score;
        }
    }
}
