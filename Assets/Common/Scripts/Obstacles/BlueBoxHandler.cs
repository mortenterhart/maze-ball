using UnityEngine;

public class BlueBoxHandler : MonoBehaviour
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
        transform.localScale = Vector3.one;
        _animator.SetBool("active", true);
        _collider.enabled = true;
    }

    private void EventsOnRedButtonTriggered()
    {
        _animator.SetTrigger("start");
        _animator.SetBool("active", true);
        _collider.enabled = true;
    }

    private void EventsOnBlueButtonTriggered()
    {
        _animator.SetTrigger("start");
        _animator.SetBool("active", false);
        _collider.enabled = false;
    }

    private void OnDestroy()
    {
        Events.BlueButtonTriggered -= EventsOnBlueButtonTriggered;
        Events.RedButtonTriggered -= EventsOnRedButtonTriggered;
        Events.ObstacleTrigger -= EventsOnObstacleTrigger;
    }
}
