using UnityEngine;

namespace Common.Scripts.Audio
{
    public class AudioHandler : MonoBehaviour
    {
        [SerializeField] private AudioSource collectableSfx;
        [SerializeField] private AudioSource fallSfx;
        [SerializeField] private AudioSource teleportSfx;
        [SerializeField] private AudioSource levelFinishSfx;
        [SerializeField] private AudioSource rotateButtonSfx;
        [SerializeField] private AudioSource redBlueButtonSfx;
        [SerializeField] private AudioSource bgm;
    
        // Start is called before the first frame update
        private void Start()
        {
            Events.Events.PlayCollectableSfx += EventsOnPlayCollectableSfx;
            Events.Events.PlayFallSfx += EventsOnPlayFallSfx;
            Events.Events.PlayTeleportSfx += EventsOnPlayTeleportSfx;
            Events.Events.PlayLevelFinishSfx += EventsOnPlayLevelFinishSfx;
            Events.Events.PlayRotateButtonSfx += EventsOnPlayRotateButtonSfx;
            Events.Events.PlayRedBlueButtonSfx += EventsOnPlayRedBlueButtonSfx;
            Events.Events.StopBgm += EventsOnStopBgm;
        }

        void EventsOnStopBgm()
        {
            bgm.Stop();
        }

        void EventsOnPlayRedBlueButtonSfx()
        {
            redBlueButtonSfx.PlayOneShot(redBlueButtonSfx.clip);
        }

        void EventsOnPlayRotateButtonSfx()
        {
            rotateButtonSfx.PlayOneShot(rotateButtonSfx.clip);
        }

        void EventsOnPlayLevelFinishSfx()
        {
            levelFinishSfx.PlayOneShot(levelFinishSfx.clip);
        }

        void EventsOnPlayTeleportSfx()
        {
            teleportSfx.PlayOneShot(teleportSfx.clip);
        }

        void EventsOnPlayFallSfx()
        {
            fallSfx.PlayOneShot(fallSfx.clip);
        }

        private void EventsOnPlayCollectableSfx()
        {
            // Play sound effect without interruption
            collectableSfx.PlayOneShot(collectableSfx.clip);
        }
    
        private void OnDestroy()
        {
            Events.Events.PlayCollectableSfx -= EventsOnPlayCollectableSfx;
            Events.Events.PlayFallSfx -= EventsOnPlayFallSfx;
            Events.Events.PlayTeleportSfx -= EventsOnPlayTeleportSfx;
            Events.Events.PlayLevelFinishSfx -= EventsOnPlayLevelFinishSfx;
            Events.Events.PlayRotateButtonSfx -= EventsOnPlayRotateButtonSfx;
            Events.Events.PlayRedBlueButtonSfx -= EventsOnPlayRedBlueButtonSfx;
            Events.Events.StopBgm -= EventsOnStopBgm;
        }
    }
}
