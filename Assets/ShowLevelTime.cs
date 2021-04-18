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
        _timeText.text = TimerHelper.TimeFloatToText(time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
