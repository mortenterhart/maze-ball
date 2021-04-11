using UnityEngine;

namespace Morten.Scripts
{
    public class BallForceDown : MonoBehaviour
    {
        [SerializeField] private float forceDown;

        private Rigidbody _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            _rb.AddForce(0, forceDown, 0);
        }
    }
}
