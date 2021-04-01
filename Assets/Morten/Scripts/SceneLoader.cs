using UnityEngine;
using UnityEngine.SceneManagement;

namespace Morten.Scripts
{
    public class SceneLoader : MonoBehaviour
    {
        public static SceneLoader Instance;

        private int _buildSceneCount;
        private int _activeScene;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else if (Instance != this)
            {
                Destroy(gameObject);
            }

            DontDestroyOnLoad(gameObject);

            _buildSceneCount = SceneManager.sceneCountInBuildSettings;
            _activeScene = SceneManager.GetActiveScene().buildIndex;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F9))
            {
                SceneManager.LoadScene(_activeScene);
                Time.timeScale = 1;
            }

            if (Input.GetKeyDown(KeyCode.F11))
            {
                _activeScene = (_activeScene + 1) % _buildSceneCount;
                SceneManager.LoadScene(_activeScene);
                Time.timeScale = 1;
            }

            if (Input.GetKeyDown(KeyCode.F10))
            {
                _activeScene--;
                if (_activeScene < 0)
                {
                    _activeScene = _buildSceneCount - 1;
                }

                SceneManager.LoadScene(_activeScene);
                Time.timeScale = 1;
            }
        }
    }
}
