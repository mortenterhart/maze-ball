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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNewGame()
    {
        SceneManager.LoadScene(level1SceneIndex);
    }
}
