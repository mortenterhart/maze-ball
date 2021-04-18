using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTotalTime : MonoBehaviour
{
    [SerializeField] Text bestTimeText;
    
    // Start is called before the first frame update
    void Start()
    {
        var timeText = GetComponent<Text>();
        var totalTime = 0f;
        for (var i = 1; i < 11; i++)
        {
            totalTime += PlayerPrefs.GetFloat("timeForLvl" + i);
        }

        timeText.text = TimerHelper.TimeFloatToText(totalTime);

        // Handle best time
        var currentBestTime = PlayerPrefs.GetFloat("BestTime");
        if (currentBestTime == 0f || totalTime < currentBestTime)
        {
            bestTimeText.enabled = true;
            PlayerPrefs.SetFloat("BestTime", totalTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
