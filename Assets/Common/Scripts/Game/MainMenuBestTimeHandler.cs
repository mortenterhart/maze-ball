using UnityEngine;
using UnityEngine.UI;

public class MainMenuBestTimeHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var bestTime = PlayerPrefs.GetFloat("BestTime");
        if (bestTime == 0f) return;
        var bestTimeText = GetComponent<Text>();
        bestTimeText.text = "Best Time: " + TimerHelper.TimeFloatToText(bestTime);
        bestTimeText.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
