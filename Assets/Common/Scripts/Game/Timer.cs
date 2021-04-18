using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float _timer;
    private Text _timerText;
    private bool _timerActive = true;

    // Start is called before the first frame update
    private void Start()
    {
        Events.LevelFinishInitiated += EventsOnLevelFinishInitiated;
        _timerText = GetComponent<Text>();
    }

    private void EventsOnLevelFinishInitiated()
    {
        _timerActive = false;

        var levelKey = "timeForLvl" + SceneManager.GetActiveScene().buildIndex;
        var highScore = PlayerPrefs.GetFloat(levelKey, -1);

        if (_timer < highScore || highScore < 0)
        {
            PlayerPrefs.SetFloat(levelKey, _timer);
            Events.OnNewHighScore();
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (!_timerActive) return;
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
