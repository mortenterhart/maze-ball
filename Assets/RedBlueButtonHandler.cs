using UnityEngine;

public class RedBlueButtonHandler : MonoBehaviour
{
    [SerializeField] private Material blue;
    [SerializeField] private Material red;
    private bool _isBlue = true;
    private MeshRenderer _renderer;
    
    // Start is called before the first frame update
    private void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        Events.BlueButtonTriggered += EventsOnBlueButtonTriggered;
        Events.RedButtonTriggered += EventsOnRedButtonTriggered;
        EventsOnRedButtonTriggered(); // Make sure that blue button is initially activated
    }

    private void EventsOnRedButtonTriggered()
    {
        _isBlue = true;
        _renderer.material = blue;
    }

    private void EventsOnBlueButtonTriggered()
    {
        _isBlue = false;
        _renderer.material = red;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        if (_isBlue)
            Events.OnBlueButtonTriggered();
        else
            Events.OnRedButtonTriggered();
    }
}
