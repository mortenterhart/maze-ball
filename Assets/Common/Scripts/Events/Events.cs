using System;
using UnityEngine;

namespace Common.Scripts.Events
{ 
    /*
     * Can be used to create completely new events which can be invoked
     * Works like the Observer pattern
     */
    public class Events : MonoBehaviour
    {
        private static Events _instance;

        private void Awake()
        {
            if (_instance == null)
                _instance = this;
            else if (_instance != this)
                Destroy(gameObject);
        
            DontDestroyOnLoad(gameObject);
        }

        public static event Action CollectableCollected;
        public static void OnCollectableCollected()
        {
            CollectableCollected?.Invoke();
        }

        public static event Action PlayRotateButtonSfx;
        public static void OnPlayRotateButtonSfx()
        {
            PlayRotateButtonSfx?.Invoke();
        }
        
        public static event Action PlayCollectableSfx;
        public static void OnPlayCollectableSfx()
        {
            PlayCollectableSfx?.Invoke();
        }
        
        public static event Action PlayTeleportSfx;
        public static void OnPlayTeleportSfx()
        {
            PlayTeleportSfx?.Invoke();
        }
        
        public static event Action PlayFallSfx;
        public static void OnPlayFallSfx()
        {
            PlayFallSfx?.Invoke();
        }
        
        public static event Action PlayLevelFinishSfx;
        public static void OnPlayLevelFinishSfx()
        {
            PlayLevelFinishSfx?.Invoke();
        }
        
        public static event Action PlayRedBlueButtonSfx;
        public static void OnPlayRedBlueButtonSfx()
        {
            PlayRedBlueButtonSfx?.Invoke();
        }
        
        public static event Action StopBgm;
        public static void OnStopBgm()
        {
            StopBgm?.Invoke();
        }

        public static event Action RotateSwitchTriggered;
        public static void OnRotateSwitchTriggered()
        {
            RotateSwitchTriggered?.Invoke();
        }

        public static event Action BlueButtonTriggered;
        public static void OnBlueButtonTriggered()
        {
            BlueButtonTriggered?.Invoke();
        }
    
        public static event Action RedButtonTriggered;
        public static void OnRedButtonTriggered()
        {
            RedButtonTriggered?.Invoke();
        }
    
        public static event Action LevelFinishInitiated;
        public static void OnLevelFinishInitiated()
        {
            LevelFinishInitiated?.Invoke();
        }

        public static event Action ObstacleTrigger;
        public static void OnObstacleTrigger()
        {
            ObstacleTrigger?.Invoke();
        }
    }
}
