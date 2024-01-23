using System.Collections.Generic;
using SaveSystem.Savers;
using ScoreSystem;
using TimerSystem;
using UnityEngine;
using Zenject;

namespace SaveSystem
{
    public class SaveController : MonoBehaviour, ISaveDataUserController
    {
        [SerializeField] private SaveTypes saveType;
        private List<ISaveDataUser> _saveDataUsers = new();
        private SaveData _currentSaveData;
        private ISaver _currentSaver;
        private JsonSaver _jsonSaver;
        private PlayerPrefsSaver _playerPrefsSaver;
        private Score _score;
        private Timer _timer;

        [Inject]
        private void Construct(Score score, Timer timer, 
            JsonSaver jsonSaver, PlayerPrefsSaver playerPrefsSaver)
        {
            _score = score;
            _timer = timer;
            _jsonSaver = jsonSaver;
            _playerPrefsSaver = playerPrefsSaver;
        }

        private void Awake()
        {
            SetCurrentSaver();
            FillSaveDataUsers();
        }

        private void Start()
        {
            LoadSavedData();
        }

        private void OnApplicationQuit()
        {
            SaveAllUsersData();
        }
        
#if UNITY_EDITOR
        private void OnValidate()
        {
            if(!Application.isPlaying) return;
            SetCurrentSaver();
        }
#endif

        private void FillSaveDataUsers()
        {
            _saveDataUsers.Add(_score);
            _saveDataUsers.Add(_timer);
        }
        
        private void SetCurrentSaver()
        {
            _currentSaver = saveType switch
            {
                SaveTypes.Json => _jsonSaver,
                SaveTypes.PlayerPrefs => _playerPrefsSaver,
                _ => _currentSaver
            };
            Debug.Log(_currentSaver);
        }
        
        private void LoadSavedData()
        {
            _currentSaveData = _currentSaver.Load();
            LoadAllUsersData();
        }

        public void AddSaveDataUser(ISaveDataUser saveDataUser)
        {
            _saveDataUsers.Add(saveDataUser);
        }

        public void RemoveSaveDataUser(ISaveDataUser saveDataUser)
        {
            _saveDataUsers.Remove(saveDataUser);
        }

        public void SaveAllUsersData()
        {
            foreach (var saveDataUser in _saveDataUsers)
            {
                saveDataUser.Save(_currentSaveData);
            }
            _currentSaver.Save(_currentSaveData);
        }

        public void LoadAllUsersData()
        {
            foreach (var saveDataUser in _saveDataUsers)
            {
                saveDataUser.Load(_currentSaveData);
            }
        }
    }
}
