using UnityEngine;
using UnityEngine.UI;

public class CollectableTextHandler : MonoBehaviour
{
    private int _numberOfCollectables;
    private Text _numberOfCollectablesText;

    private int _totalNumberOfCollectables;

    // Start is called before the first frame update
    private void Start()
    {
        Events.CollectableCollected += EventsOnCollectableCollected;
        Events.SetTotalNumberOfCollectables += EventsOnSetTotalNumberOfCollectables;
        _numberOfCollectablesText = GetComponent<Text>();
    }

    private void EventsOnCollectableCollected()
    {
        _numberOfCollectables++;
        _numberOfCollectablesText.text = $"{_numberOfCollectables} / {_totalNumberOfCollectables}";
    }

    private void EventsOnSetTotalNumberOfCollectables(int totalNumberOfCollectables)
    {
        _totalNumberOfCollectables = totalNumberOfCollectables;
        _numberOfCollectablesText.text = $"{_numberOfCollectables} / {_totalNumberOfCollectables}";
    }

    private void OnDestroy()
    {
        Events.CollectableCollected -= EventsOnCollectableCollected;
        Events.SetTotalNumberOfCollectables -= EventsOnSetTotalNumberOfCollectables;
    }
}
