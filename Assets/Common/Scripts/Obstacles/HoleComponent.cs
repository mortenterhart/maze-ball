using UnityEngine;

public class HoleComponent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Events.OnObstacleTrigger();
        Events.OnPlayFallSfx();
    }
}

