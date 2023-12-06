using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UISystem
{
    public class AddMenuView : MonoBehaviour
    {
        [field: SerializeField] public Button AddMenuButton { get; private set; }
        [field: SerializeField] public GameObject AddMenuPanel { get; private set; }
        [field: SerializeField] public Button RemoveButton { get; private set; }
        [field: SerializeField] public TMP_Dropdown DropDown { get; private set; }
        [field: SerializeField] public TMP_InputField InputField { get; private set; }
    }
}