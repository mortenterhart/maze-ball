using UnityEngine;

public class RedBoxHandler : MonoBehaviour
{
    private Animator _animator;
    private Collider _collider;

    // Start is called before the first frame update
    private void Start()
    {
        Events.BlueButtonTriggered += EventsOnBlueButtonTriggered;
        Events.RedButtonTriggered += EventsOnRedButtonTriggered;
        Events.ObstacleTrigger += EventsOnObstacleTrigger;
        _animator = GetComponent<Animator>();
        _collider = GetComponent<Collider>();
    }

    void EventsOnObstacleTrigger()
    {
        transform.localScale = Vector3.zero;
        _animator.SetBool("active", false);
        _collider.enabled = false;
    }

    private void EventsOnRedButtonTriggered()
    {
        _animator.SetTrigger("start");
        _animator.SetBool("active", false);
        _collider.enabled = false;
    }

    private void EventsOnBlueButtonTriggered()
    {
        _animator.SetTrigger("start");
        _animator.SetBool("active", true);
        _collider.enabled = true;
    }

    private void OnDestroy()
    {
        Events.BlueButtonTriggered -= EventsOnBlueButtonTriggered;
        Events.RedButtonTriggered -= EventsOnRedButtonTriggered;
        Events.ObstacleTrigger -= EventsOnObstacleTrigger;
    }
}