using ScoreSystem.Data;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Zenject;

namespace ScoreSystem.UI
{
    public class ScoreButton : Button
    {
        private Score _score;
        private ScoreSettings _scoreSettings;
        private float _pressTime;
        private float _totalPressedTime;

        [Inject]
        private void Construct(Score score, ScoreSettings scoreSettings)
        {
            _score = score;
            _scoreSettings = scoreSettings;
        }
        
        public override void OnPointerDown(PointerEventData eventData)
        {
            base.OnPointerDown(eventData);
            
            _pressTime = Time.time;
        }
    
        public override void OnPointerUp(PointerEventData eventData)
        {
            base.OnPointerUp(eventData);
            
            CalculateScore();
        }

        private void CalculateScore()
        {
            _totalPressedTime = Time.time - _pressTime;
            _score.Add(_scoreSettings.ButtonScorePerSecond * _totalPressedTime);
        }
    }
}