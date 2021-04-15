using UnityEngine;
using UnityEngine.UI;

namespace Common.Scripts
{
    public class Timer : MonoBehaviour
    {
        private float _timer;
        private Text _timerText;
    
        // Start is called before the first frame update
        void Start()
        {
            _timerText = GetComponent<Text>();
            //Time.timeScale = 0.1f;
        }

        // Update is called once per frame
        void Update()
        {
            _timer += Time.deltaTime;
            var milliSeconds = (int) (_timer * 100f);
            var seconds = (int) _timer;
            var minutes = (int) (_timer / 60);
            milliSeconds %= 100;
            seconds %= 60;
            var milliSecondsStr = milliSeconds.ToString("00");
            var secondsStr = seconds.ToString("00");
            var minutesStr = minutes.ToString("00");
            _timerText.text = $"{minutesStr}:{secondsStr}:{milliSecondsStr}";
        }
    }
}
