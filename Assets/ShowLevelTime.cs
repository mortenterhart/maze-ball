using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowLevelTime : MonoBehaviour
{
    [SerializeField] int sceneIndex;
    Text _timeText;
    
    // Start is called before the first frame update
    void Start()
    {
        _timeText = GetComponent<Text>();
        var time = PlayerPrefs.GetFloat("timeForLvl" + sceneIndex);
        
        var milliSeconds = (int) (time * 100f);
        var seconds = (int) time;
        var minutes = (int) (time / 60);
        milliSeconds %= 100;
        seconds %= 60;
        var milliSecondsStr = milliSeconds.ToString("00");
        var secondsStr = seconds.ToString("00");
        var minutesStr = minutes.ToString("00");
        _timeText.text = $"{minutesStr}:{secondsStr}:{milliSecondsStr}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
