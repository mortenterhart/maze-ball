using UnityEngine;

namespace Common.Scripts.Obstacles
{
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
            Events.Events.BlueButtonTriggered += EventsOnBlueButtonTriggered;
            Events.Events.RedButtonTriggered += EventsOnRedButtonTriggered;
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
                Events.Events.OnBlueButtonTriggered();
            else
                Events.Events.OnRedButtonTriggered();
        }
    
        private void OnDestroy()
        {
            Events.Events.BlueButtonTriggered -= EventsOnBlueButtonTriggered;
            Events.Events.RedButtonTriggered -= EventsOnRedButtonTriggered;
        }
    }
}
