using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelFinishHandler : MonoBehaviour
{
    [SerializeField] private Text levelFinishText;

    // Start is called before the first frame update
    private void Start()
    {
        Events.LevelFinishInitiated += EventsOnLevelFinishInitiated;
    }

    private void EventsOnLevelFinishInitiated()
    {
        levelFinishText.gameObject.SetActive(true);
        Events.OnStopBgm();
        Events.OnPlayLevelFinishSfx();
        PlayerPrefs.SetInt("levelSave", SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(FinishLevel());
    }

    private IEnumerator FinishLevel()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnDestroy()
    {
        Events.LevelFinishInitiated -= EventsOnLevelFinishInitiated;
    }
}
