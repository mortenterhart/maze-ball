using UnityEngine;

public class HoleTrigger : MonoBehaviour
{
    [SerializeField] private GameObject respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var _playerRb = other.GetComponent<Rigidbody>();
            _playerRb.velocity = Vector3.zero;
            _playerRb.angularVelocity = Vector3.zero;
            _playerRb.rotation = Quaternion.identity;

            other.transform.position = respawnPoint.transform.position;
        }
    }
}
