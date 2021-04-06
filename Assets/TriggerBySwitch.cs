using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBySwitch : MonoBehaviour
{
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        
        Events.SwitchTriggered += EventsOnSwitchTriggered;
    }

    private void EventsOnSwitchTriggered()
    {
        _animator.SetTrigger("rotate");
    }
}
