using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTotalTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var timeText = GetComponent<Text>();
        var totalTime = 0f;
        for (int i = 1; i < 11; i++)
        {
            totalTime += PlayerPrefs.GetFloat("timeForLvl" + i);
        }
        
        var milliSeconds = (int) (totalTime * 100f);
        var seconds = (int) totalTime;
        var minutes = (int) (totalTime / 60);
        milliSeconds %= 100;
        seconds %= 60;
        var milliSecondsStr = milliSeconds.ToString("00");
        var secondsStr = seconds.ToString("00");
        var minutesStr = minutes.ToString("00");
        timeText.text = $"{minutesStr}:{secondsStr}:{milliSecondsStr}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
