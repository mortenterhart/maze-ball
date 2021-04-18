using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] private int level1SceneIndex;
    [SerializeField] private int mainMenuSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    void Update()
    {
    
    }

    public void OnNewGame()
    {
        PlayerPrefs.SetInt("levelSave", 0);
        SceneManager.LoadScene(level1SceneIndex);
    }

    public void OnContinue()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("levelSave"));
    }

    public void OnBackToMainMenu()
    {
        SceneManager.LoadScene(mainMenuSceneIndex);
    }
}

