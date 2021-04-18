using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] private int level1SceneIndex;
    [SerializeField] private int mainMenuSceneIndex;
    [SerializeField] private int selectLevelSceneIndex;

    public void OnNewGame()
    {
        PlayerPrefs.SetInt("levelSave", 0);
        SceneManager.LoadScene(level1SceneIndex);
    }

    public void OnContinue()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("levelSave"));
    }

    public void OnSelectLevel()
    {
        SceneManager.LoadScene(selectLevelSceneIndex);
    }

    public void OnBackToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainMenuSceneIndex);
    }
}


