using UnityEngine;

namespace Common.Scripts.Obstacles
{
    public class TeleportHandler : MonoBehaviour
    {
        [SerializeField] private GameObject targetPos;

        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player")) return;

            // Reset player velocity and rotation
            var rb = other.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.rotation = Quaternion.identity;
            rb.angularVelocity = Vector3.zero;

            other.transform.position = targetPos.transform.position;
        }
    }
}
