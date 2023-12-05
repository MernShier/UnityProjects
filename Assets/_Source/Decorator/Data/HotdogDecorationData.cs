using UnityEngine;

namespace Decorator.Data
{
    [CreateAssetMenu(fileName = "HotdogDecorationDataSO", menuName = "SO/Decorator/HotdogDecorationDataSO")]
    public class HotdogDecorationData : ScriptableObject
    {
        [field: SerializeField] public string ExtraName { get; private set; }
        [field: SerializeField] public int ExtraPrice { get; private set; }
        [field: SerializeField] public int ExtraWeight { get; private set; }
    }
}