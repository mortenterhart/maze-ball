using UnityEngine;

namespace Common.Scripts.Collectable
{
    public class InitLevelFinishOnAllCollected : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            Events.Events.CollectableCollected += EventsOnCollectableCollected;
        }

        private void EventsOnCollectableCollected()
        {
            if (transform.childCount == 1)
                // Only 1 Collectable object should exist which runs its destroy animation
                Events.Events.OnLevelFinishInitiated();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    
        private void OnDestroy()
        {
            Events.Events.CollectableCollected -= EventsOnCollectableCollected;
        }
    }
}
