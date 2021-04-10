using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerByRotateSwitch : MonoBehaviour
{
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        
        Events.RotateSwitchTriggered += EventsOnRotateSwitchTriggered;
    }

    private void EventsOnRotateSwitchTriggered()
    {
        _animator.SetTrigger("rotate");
    }
}