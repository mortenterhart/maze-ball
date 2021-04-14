using UnityEngine;

namespace Gerry.Scripts
{
    public class RotateByInput : MonoBehaviour
    {
        [SerializeField] private float speed = 20f;
        [SerializeField] private float moveBackSpeed = 1f;
        [SerializeField] private float maxRotation = 5f;

        private void FixedUpdate()
        {
            Vector3 vel;
            vel.x = Input.GetAxis("Vertical");
            vel.y = 0f;
            vel.z = Input.GetAxis("Horizontal") * -1f;

            if (Input.GetAxisRaw("Vertical") == 0f)
                vel.x = Mathf.LerpAngle(transform.eulerAngles.x, 0f, Time.deltaTime * moveBackSpeed);
            else
                vel.x = transform.eulerAngles.x + vel.x * speed * Time.deltaTime;
            if (Input.GetAxisRaw("Horizontal") == 0f)
                vel.z = Mathf.LerpAngle(transform.eulerAngles.z, 0f, Time.deltaTime * moveBackSpeed);
            else
                vel.z = transform.eulerAngles.z + vel.z * speed * Time.deltaTime;

            transform.eulerAngles = vel;
            
            // Handle max rotation
            var newAngles = transform.eulerAngles;
            if (newAngles.x < 180f && newAngles.x > maxRotation) newAngles.x = maxRotation;
            if (newAngles.x > 180f && newAngles.x < 360f - maxRotation) newAngles.x = 360f - maxRotation;
            if (newAngles.z < 180f && newAngles.z > maxRotation) newAngles.z = maxRotation;
            if (newAngles.z > 180f && newAngles.z < 360f - maxRotation) newAngles.z = 360f - maxRotation;

            transform.eulerAngles = newAngles;
        }
    }
}
