using UnityEngine;

namespace Decorator.Data
{
    [CreateAssetMenu(fileName = "HotdogDataSO", menuName = "SO/Decorator/HotdogDataSO")]
    public class HotdogData : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public int Price { get; private set; }
        [field: SerializeField] public int Weight { get; private set; }
    }
}