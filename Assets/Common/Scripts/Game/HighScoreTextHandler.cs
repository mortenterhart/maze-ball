using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighScoreTextHandler : MonoBehaviour
{
    private Text _highScoreText;
    
    private void Start()
    {
        Events.NewHighScore += EventsOnNewHighScore;

        _highScoreText = GetComponent<Text>();
        
        UpdateHighScoreText();
    }
    
    private void EventsOnNewHighScore()
    {
        UpdateHighScoreText();
    }

    private void UpdateHighScoreText()
    {
        var highScore = PlayerPrefs.GetFloat("timeForLvl" + SceneManager.GetActiveScene().buildIndex);
        if (highScore != 0f)
            _highScoreText.text = TimerHelper.TimeFloatToText(highScore);
        else
            _highScoreText.text = "99:99:99";
    }
    
    private void OnDestroy()
    {
        Events.NewHighScore -= EventsOnNewHighScore;
    }
}
        
