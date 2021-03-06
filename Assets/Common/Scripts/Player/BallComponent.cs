using UnityEngine;

public class BallComponent : MonoBehaviour
{
    [SerializeField] private GameObject respawnPos;
    
    private Rigidbody _rb;

    // Start is called before the first frame update
    private void Start()
    {
        Events.ObstacleTrigger += EventsOnObstacleTrigger;
        _rb = GetComponent<Rigidbody>();
    }

    private void EventsOnObstacleTrigger()
    {
        // Reset player velocity and rotation
        _rb.velocity = Vector3.zero;
        _rb.rotation = Quaternion.identity;
        _rb.angularVelocity = Vector3.zero;

        transform.position = respawnPos.transform.position;
    }

    void OnDestroy()
    {
        Events.ObstacleTrigger -= EventsOnObstacleTrigger;
    }
}
