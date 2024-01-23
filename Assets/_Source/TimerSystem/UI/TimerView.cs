using System;
using TMPro;
using UnityEngine;
using Zenject;

namespace TimerSystem.UI
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField] private TMP_Text timerText;
        private Timer _timer;

        [Inject]
        private void Construct(Timer timer)
        {
            _timer = timer;
        }

        private void Awake()
        {
            Bind();
        }

        private void Start()
        {
            UpdateTimerText();
        }

        private void Bind()
        {
            _timer.OnTimerUpdate += UpdateTimerText;
        }
        
        private void UpdateTimerText() =>
            timerText.text = $"Played: {_timer.PlayedTime:0.00}";
    }
}
