using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerHelper : MonoBehaviour
{
    public static string TimeFloatToText(float timeValue)
    {
        var milliSeconds = (int) (timeValue * 100f);
        var seconds = (int) timeValue;
        var minutes = (int) (timeValue / 60);
        milliSeconds %= 100;
        seconds %= 60;
        var milliSecondsStr = milliSeconds.ToString("00");
        var secondsStr = seconds.ToString("00");
        var minutesStr = minutes.ToString("00");
        return $"{minutesStr}:{secondsStr}:{milliSecondsStr}";
    }
}
