using UnityEngine;

namespace Gerry.Scripts
{
    public class RotateByInput : MonoBehaviour
    {
        [SerializeField] private float speed;

        private void FixedUpdate()
        {
            Vector3 vel;
            vel.x = Input.GetAxis("Vertical");
            vel.y = 0f;
            vel.z = Input.GetAxis("Horizontal") * -1f;

            transform.eulerAngles = vel * speed * Time.deltaTime;
        }
    }
}
