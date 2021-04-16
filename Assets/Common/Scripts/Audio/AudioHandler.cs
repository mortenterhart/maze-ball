using UnityEngine;

namespace Common.Scripts.Audio
{
    public class AudioHandler : MonoBehaviour
    {
        [SerializeField] private AudioSource collectableSfx;
    
        // Start is called before the first frame update
        private void Start()
        {
            Events.Events.PlayCollectableSfx += EventsOnPlayCollectableSfx;
        }

        private void EventsOnPlayCollectableSfx()
        {
            // Play sound effect without interruption
            collectableSfx.PlayOneShot(collectableSfx.clip);
        }
    
        private void OnDestroy()
        {
            Events.Events.PlayCollectableSfx -= EventsOnPlayCollectableSfx;
        }
    }
}
