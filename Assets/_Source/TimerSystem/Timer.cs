using System;
using SaveSystem;
using UnityEngine;

namespace TimerSystem
{
    public class Timer : MonoBehaviour, ISaveDataUser
    {
        public event Action OnTimerUpdate;
        [field:SerializeField] public float PlayedTime { get; set; }
    
        private void Update()
        {
            UpdateTimer();
        }

        private void UpdateTimer()
        {
            PlayedTime += Time.deltaTime;
            OnTimerUpdate?.Invoke();
        }

        public void Save(SaveData saveData)
        {
            saveData.Playtime = PlayedTime;
        }

        public void Load(SaveData saveData)
        {
            PlayedTime = saveData.Playtime;
        }
    }
}
