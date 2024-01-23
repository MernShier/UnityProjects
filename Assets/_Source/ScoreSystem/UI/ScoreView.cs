using System;
using TMPro;
using UnityEngine;
using Zenject;

namespace ScoreSystem.UI
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TMP_Text scoreText;
        private Score _score;

        [Inject]
        private void Construct(Score score)
        {
            _score = score;
        }

        private void Awake()
        {
            Bind();
        }

        private void Start()
        {
            UpdateScoreText();
        }

        private void Bind()
        {
            _score.OnScoreChange += UpdateScoreText;
        }

        private void UpdateScoreText() =>
            scoreText.text = $"Score: {_score.Value:0.00}";
    }
}