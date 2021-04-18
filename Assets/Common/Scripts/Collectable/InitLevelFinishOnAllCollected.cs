using UnityEngine;

public class InitLevelFinishOnAllCollected : MonoBehaviour
{
    private int _totalNumberOfCollectables;
    private bool _hasSetTotalNumber;
    
    // Start is called before the first frame update
    private void Start()
    {
        Events.CollectableCollected += EventsOnCollectableCollected;

        // Set total number of collectables in CollectableTextHandler
        _totalNumberOfCollectables = transform.childCount;
    }

    private void Update()
    {
        if (_hasSetTotalNumber) return;

        Events.OnSetTotalNumberOfCollectables(_totalNumberOfCollectables);
        _hasSetTotalNumber = true;
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

