using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    [SerializeField] private AudioSource collectableSfx;
    
    // Start is called before the first frame update
    private void Start()
    {
        Events.PlayCollectableSfx += EventsOnPlayCollectableSfx;
    }

    private void EventsOnPlayCollectableSfx()
    {
        collectableSfx.Play();
    }
}
