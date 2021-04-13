using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartHandler : MonoBehaviour
{
    [SerializeField] private int level1SceneIndex;
    
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
}
