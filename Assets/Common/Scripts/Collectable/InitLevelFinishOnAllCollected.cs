using UnityEngine;

public class InitLevelFinishOnAllCollected : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Events.CollectableCollected += EventsOnCollectableCollected;

        // Set total number of collectables in CollectableTextHandler
        Events.OnSetTotalNumberOfCollectables(transform.childCount);
    }

    private void EventsOnCollectableCollected()
    {
        if (transform.childCount == 1)
            // Only 1 Collectable object should exist which runs its destroy animation
            Events.OnLevelFinishInitiated();
    }

    private void OnDestroy()
    {
        Events.CollectableCollected -= EventsOnCollectableCollected;
    }
}

