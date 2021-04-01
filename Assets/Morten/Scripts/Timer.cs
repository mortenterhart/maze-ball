using UnityEngine;
using UnityEngine.UI;

namespace Morten.Scripts
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private Text highScoreText;

        private const string HighScoreKey = "mazeBallHighScore";

        private float _timer;
        private Text _timerText;

        private float _highScore;

        private bool _stopped;

        private void Start()
        {
            _timerText = GetComponent<Text>();
            _timerText.text = $"{_timer:00}";

            _highScore = PlayerPrefs.GetFloat(HighScoreKey, -1);
            highScoreText.text = _highScore > 0 ? $"{_highScore:N2}" : "---";
        }

        private void Update()
        {
            if (_stopped)
            {
                return;
            }

            _timer += Time.deltaTime;
            _timerText.text = $"{_timer:N2}";
        }

        public void Stop()
        {
            _stopped = true;

            if (_timer < _highScore || _highScore < 0)
            {
                _highScore = _timer;
                highScoreText.text = $"{_highScore:N2}";
                PlayerPrefs.SetFloat(HighScoreKey, _highScore);
            }
        }

        public void Restart()
        {
            _stopped = false;
            _timer = 0f;
            _timerText.text = $"{_timer:N2}";
        }
    }
}
