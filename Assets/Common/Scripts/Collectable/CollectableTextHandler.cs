using UnityEngine;
using UnityEngine.UI;

namespace Common.Scripts.Collectable
{
    public class CollectableTextHandler : MonoBehaviour
    {
        private int _numberOfCollectables;
        private Text _numberOfCollectablesText;
    
        // Start is called before the first frame update
        private void Start()
        {
            Events.Events.CollectableCollected += EventsOnCollectableCollected;
            _numberOfCollectablesText = GetComponent<Text>();
        }

        private void EventsOnCollectableCollected()
        {
            _numberOfCollectables++;
            _numberOfCollectablesText.text = _numberOfCollectables.ToString();
        }

        private void OnDestroy()
        {
            Events.Events.CollectableCollected -= EventsOnCollectableCollected;
        }
    }
}
