using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UISystem
{
    public class RemoveMenuView : MonoBehaviour
    {
        [field: SerializeField] public Button RemoveMenuButton { get; private set; }
        [field: SerializeField] public GameObject RemoveMenuPanel { get; private set; }
        [field: SerializeField] public Button RemoveButton { get; private set; }
        [field: SerializeField] public TMP_Dropdown DropDown { get; private set; }
        [field: SerializeField] public TMP_InputField InputField { get; private set; }
    }
}