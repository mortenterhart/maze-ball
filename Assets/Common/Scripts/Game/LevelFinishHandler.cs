using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Common.Scripts.Game
{
    public class LevelFinishHandler : MonoBehaviour
    {
        [SerializeField] private Text levelFinishText;
        [SerializeField] private int nextSceneIndex;
    
        // Start is called before the first frame update
        private void Start()
        {
            Events.Events.LevelFinishInitiated += EventsOnLevelFinishInitiated;
        }

        private void EventsOnLevelFinishInitiated()
        {
            levelFinishText.gameObject.SetActive(true);
            PlayerPrefs.SetInt("levelSave", nextSceneIndex);
            StartCoroutine(FinishLevel());
        }

        private IEnumerator FinishLevel()
        {
            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene(nextSceneIndex);
        }

        private void OnDestroy()
        {
            Events.Events.LevelFinishInitiated -= EventsOnLevelFinishInitiated;
        }
    }
}
