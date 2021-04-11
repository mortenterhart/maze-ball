using UnityEngine;

namespace Morten.Scripts
{
    public class FinishTrigger : MonoBehaviour
    {
        [SerializeField] private GameObject respawnPoint;

        private Timer _timer;
        private MazeController _mazeController;

        private void Awake()
        {
            _timer = FindObjectOfType<Timer>();
            _mazeController = FindObjectOfType<MazeController>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _timer.Stop();
                _mazeController.ResetRotation();

                var playerRb = other.GetComponent<Rigidbody>();
                playerRb.velocity = Vector3.zero;
                playerRb.angularVelocity = Vector3.zero;
                playerRb.rotation = Quaternion.identity;

                other.transform.position = respawnPoint.transform.position;

                _timer.Restart();
            }
        }
    }
}
