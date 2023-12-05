using System.Collections.Generic;
using Decorator.Data;
using UnityEngine;

namespace Decorator
{
    public class HotdogDebugger : MonoBehaviour
    {
        [SerializeField] private HotdogData classicHotdogData;
        [SerializeField] private HotdogData meatHotdogData;
        [SerializeField] private HotdogData caesarHotdogData;
        [SerializeField] private HotdogDecorationData picklesHotdogDecorationData;
        [SerializeField] private HotdogDecorationData sweetOnionsHotdogDecorationData;
        private List<Hotdog> _hotdogs = new ();

        private void Awake()
        {
            InitializeHotdogs();
            DebugHotdogs();
        }

        private void InitializeHotdogs()
        {
            var classicHotdog = new ClassicHotdog(classicHotdogData.Name, classicHotdogData.Price, classicHotdogData.Weight);
            var meatHotdog = new MeatHotdog(meatHotdogData.Name, meatHotdogData.Price, meatHotdogData.Weight);
            var caesarHotdog = new CaesarHotdog(caesarHotdogData.Name, caesarHotdogData.Price, caesarHotdogData.Weight);
            var picklesClassicHotdog = new PicklesHotdog(classicHotdog, picklesHotdogDecorationData);
            var sweetOnionsClassicHotdog = new SweetOnionsHotdog(classicHotdog, sweetOnionsHotdogDecorationData);
            var picklesMeatHotdog = new PicklesHotdog(meatHotdog, picklesHotdogDecorationData);
            var sweetOnionsMeatHotdog = new SweetOnionsHotdog(meatHotdog, sweetOnionsHotdogDecorationData);
            var picklesCaesarHotdog = new PicklesHotdog(caesarHotdog, picklesHotdogDecorationData);
            var sweetOnionsCaesarHotdog = new SweetOnionsHotdog(caesarHotdog, sweetOnionsHotdogDecorationData);
            var picklesAndSweetOnionsClassicHotdog = new PicklesHotdog(picklesClassicHotdog, sweetOnionsHotdogDecorationData);
            
            _hotdogs.Add(classicHotdog);
            _hotdogs.Add(picklesClassicHotdog);
            _hotdogs.Add(sweetOnionsClassicHotdog);
            _hotdogs.Add(meatHotdog);
            _hotdogs.Add(picklesMeatHotdog);
            _hotdogs.Add(sweetOnionsMeatHotdog);
            _hotdogs.Add(caesarHotdog);
            _hotdogs.Add(picklesCaesarHotdog);
            _hotdogs.Add(sweetOnionsCaesarHotdog);
            _hotdogs.Add(picklesAndSweetOnionsClassicHotdog);
        }

        public void DebugHotdogs()
        {
            foreach (var hotdog in _hotdogs)
            {
                Debug.Log($"{hotdog.GetName()} ({hotdog.GetWeight()}) - {hotdog.GetCost()}");
            }
        }
    }
}