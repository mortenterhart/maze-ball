using UnityEngine;

public class TeleportHandler : MonoBehaviour
{
    [SerializeField] private Vector3 targetPos;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        other.gameObject.transform.position = targetPos;
    }
}
