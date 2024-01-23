using UnityEngine;

namespace SaveSystem.Savers
{
    public class PlayerPrefsSaver : ISaver
    {
        public void Save(SaveData saveData)
        {
            PlayerPrefs.SetFloat("Score", saveData.Score);
            PlayerPrefs.SetFloat("Playtime", saveData.Playtime);
        }

        public SaveData Load()
        {
            var saveData = new SaveData
            {
                Score = PlayerPrefs.GetFloat("Score"),
                Playtime = PlayerPrefs.GetFloat("Playtime")
            };
            return saveData;
        }
    }
}
