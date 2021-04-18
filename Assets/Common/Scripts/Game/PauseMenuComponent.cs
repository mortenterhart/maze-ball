using System.Collections;
using System.Collections.Generic;
using Common.Scripts.Events;
using UnityEngine;

public class PauseMenuComponent : MonoBehaviour
{
    [SerializeField] GameObject pauseMenuObj;
    bool _pauseActive;
    bool _buttonDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Pause") > 0f)
        {
            if (!_buttonDown)
            {
                _buttonDown = true;
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
        else
        {
            _buttonDown = false;
        }
    }
}
