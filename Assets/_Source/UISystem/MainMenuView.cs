using Core.UISystem;
using UnityEngine;
using UnityEngine.UI;

namespace UISystem
{
    public class MainMenuView : MonoBehaviour
    {
        [field: SerializeField] public Button MainMenuButton { get; private set; }
        [field: SerializeField] public GameObject MainMenuPanel { get; private set; }
        [field: SerializeField] public Button ResetButton { get; private set; }
        [field: SerializeField] public Transform Group { get; private set; }
        [field: SerializeField] public ResourceView Resource { get; private set; }
    }
}