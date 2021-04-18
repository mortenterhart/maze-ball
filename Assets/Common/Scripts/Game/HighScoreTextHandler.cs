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
        _highScoreText.text = TimerHelper.TimeFloatToText(highScore);
    }
    
    private void OnDestroy()
    {
        Events.NewHighScore -= EventsOnNewHighScore;
    }
}
        
