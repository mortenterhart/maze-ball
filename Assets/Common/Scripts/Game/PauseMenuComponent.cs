using UnityEngine;

public class PauseMenuComponent : MonoBehaviour
{
    [SerializeField] GameObject pauseMenuObj;
    bool _pauseActive;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if (_pauseActive)
            {
                _pauseActive = false;
                pauseMenuObj.SetActive(false);
                Time.timeScale = 1f;
                Events.OnPlayBgm();
            }
            else
            {
                _pauseActive = true;
                pauseMenuObj.SetActive(true);
                Time.timeScale = 0f;
                Events.OnPauseBgm();
            }
        }
    }
}