using System;
using UnityEngine;

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

    public static event Action PlayCollectableSfx;
    public static void OnPlayCollectableSfx()
    {
        PlayCollectableSfx?.Invoke();
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
}
