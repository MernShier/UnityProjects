using TMPro;
using UnityEngine;

namespace Core.UISystem
{
    public class ResourceView : MonoBehaviour
    {
        [field: SerializeField] public TMP_Text ResourceName { get; private set; }
        [field: SerializeField] public TMP_Text ResourceAmount { get; private set; }
    }
}