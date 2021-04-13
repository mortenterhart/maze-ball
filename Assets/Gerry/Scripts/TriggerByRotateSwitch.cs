using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerByRotateSwitch : MonoBehaviour
{
    enum Direction
    {
        Rotate90,
        Rotate180,
        RotateNeg90,
        RotateBack90,
        RotateBackNeg90
    }

    [SerializeField] private Direction direction;

    private Animator _animator;
    Vector3 _initialRotation;
    
    // Start is called before the first frame update
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _initialRotation = transform.localEulerAngles;
        
        Events.RotateSwitchTriggered += EventsOnRotateSwitchTriggered;
        Events.ObstacleTrigger += EventsOnObstacleTrigger;
    }

    void EventsOnObstacleTrigger()
    {
        _animator.SetBool("rotateBack90", false);
        _animator.SetBool("rotateBack-90", false);
        _animator.ResetTrigger("rotate90");
        _animator.ResetTrigger("rotate180");
        _animator.ResetTrigger("rotate-90");
        transform.localEulerAngles = _initialRotation;
    }

    private void EventsOnRotateSwitchTriggered()
    {
        switch (direction)
        {
            case Direction.Rotate90:
                _animator.SetTrigger("rotate90");
                break;
            case Direction.Rotate180:
                _animator.SetTrigger("rotate180");
                break;
            case Direction.RotateNeg90:
                _animator.SetTrigger("rotate-90");
                break;
            case Direction.RotateBack90:
                _animator.SetBool("rotateBack90", !_animator.GetBool("rotateBack90"));
                _animator.SetTrigger("rotate90");
                break;
            case Direction.RotateBackNeg90:
                _animator.SetBool("rotateBack-90", !_animator.GetBool("rotateBack-90"));
                _animator.SetTrigger("rotate-90");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void OnDestroy()
    {
        Events.RotateSwitchTriggered -= EventsOnRotateSwitchTriggered;
        Events.ObstacleTrigger -= EventsOnObstacleTrigger;
    }
}
