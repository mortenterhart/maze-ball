using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevelHandler : MonoBehaviour
{
    public void SelectLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
