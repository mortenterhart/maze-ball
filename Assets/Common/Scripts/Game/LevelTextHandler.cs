using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelTextHandler : MonoBehaviour
{
    private void Start()
    {
        var levelText = GetComponent<Text>();
        levelText.text = $"Level {SceneManager.GetActiveScene().buildIndex}";
    }
}
