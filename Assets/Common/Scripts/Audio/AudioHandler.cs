using UnityEngine;

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
        Events.PlayCollectableSfx += EventsOnPlayCollectableSfx;
        Events.PlayFallSfx += EventsOnPlayFallSfx;
        Events.PlayTeleportSfx += EventsOnPlayTeleportSfx;
        Events.PlayLevelFinishSfx += EventsOnPlayLevelFinishSfx;
        Events.PlayRotateButtonSfx += EventsOnPlayRotateButtonSfx;
        Events.PlayRedBlueButtonSfx += EventsOnPlayRedBlueButtonSfx;
        Events.StopBgm += EventsOnStopBgm;
        Events.PauseBgm += EventsOnPauseBgm;
        Events.PlayBgm += EventsOnPlayBgm;
    }

    void EventsOnPlayBgm()
    {
        bgm.UnPause();
    }

    void EventsOnPauseBgm()
    {
        //_bgmPlaytime = bgm.time;
        bgm.Pause();
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
        fallSfx.PlayOneShot(fallSfx.clip, 0.4f);
    }

    private void EventsOnPlayCollectableSfx()
    {
        // Play sound effect without interruption
        collectableSfx.PlayOneShot(collectableSfx.clip);
    }

    private void OnDestroy()
    {
        Events.PlayCollectableSfx -= EventsOnPlayCollectableSfx;
        Events.PlayFallSfx -= EventsOnPlayFallSfx;
        Events.PlayTeleportSfx -= EventsOnPlayTeleportSfx;
        Events.PlayLevelFinishSfx -= EventsOnPlayLevelFinishSfx;
        Events.PlayRotateButtonSfx -= EventsOnPlayRotateButtonSfx;
        Events.PlayRedBlueButtonSfx -= EventsOnPlayRedBlueButtonSfx;
        Events.StopBgm -= EventsOnStopBgm; 
        Events.PauseBgm -= EventsOnPauseBgm;
        Events.PlayBgm -= EventsOnPlayBgm;
    }
}

