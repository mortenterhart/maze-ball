using UnityEngine;

public class RedBoxHandler : MonoBehaviour
{
    private Animator _animator;
    private Collider _collider;
    
    // Start is called before the first frame update
    void Start()
    {
        Events.BlueButtonTriggered += EventsOnBlueButtonTriggered;
        Events.RedButtonTriggered += EventsOnRedButtonTriggered;
        _animator = GetComponent<Animator>();
        _collider = GetComponent<Collider>();
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
}