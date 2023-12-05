using System;
using UnityEngine;
using UnityEngine.UI;

namespace UISystem.Data
{
    [Serializable]
    public class AttackTypeButtonsView
    {
        [field: SerializeField] public Button AttackType1Button { get; private set; }
        [field: SerializeField] public Button AttackType2Button { get; private set; }
        [field: SerializeField] public Button AttackType3Button { get; private set; }
    }
}