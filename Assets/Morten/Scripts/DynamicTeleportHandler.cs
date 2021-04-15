using UnityEngine;

namespace Morten.Scripts
{
    public class DynamicTeleportHandler : MonoBehaviour
    {
        [SerializeField] private GameObject targetPos;

        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player")) return;
            
            // Reset player velocity and rotation
            var playerRb = other.GetComponent<Rigidbody>();
            playerRb.velocity = Vector3.zero;
            playerRb.angularVelocity = Vector3.zero;
            playerRb.rotation = Quaternion.identity;

            other.transform.position = targetPos.transform.position;
        }
    }
}