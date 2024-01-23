using UnityEngine;

namespace ScoreSystem.Data
{
    [CreateAssetMenu(fileName = "ScoreSettingsSO", menuName = "SO/ScoreSystem/ScoreSettingsSO")]
    public class ScoreSettings : ScriptableObject
    {
        [field:SerializeField] public float ButtonScorePerSecond { get; set; }
    }
}
