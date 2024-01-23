using System.IO;
using UnityEngine;

namespace SaveSystem.Savers
{
    public class JsonSaver : ISaver
    {
        private SaveData _loadData = new();
        
        public void Save(SaveData saveData)
        {
            File.WriteAllText(Application.persistentDataPath + "/JSON.json", JsonUtility.ToJson(saveData));
        }

        public SaveData Load()
        {
            _loadData = JsonUtility.FromJson<SaveData>(File.ReadAllText(Application.persistentDataPath + "/JSON.json"));
            return _loadData;
        }
    }
}
