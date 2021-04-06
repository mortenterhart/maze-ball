using UnityEngine;

namespace Gerry.Scripts
{
    public class RotateByInput : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float maxAngle;

        private void FixedUpdate()
        {
            Vector3 vel;
            vel.x = Input.GetAxis("Vertical");
            vel.y = 0f;
            vel.z = Input.GetAxis("Horizontal") * -1f;

            var transform1 = transform;
            var eulerAngles = transform1.eulerAngles;
            eulerAngles += vel * Time.deltaTime * speed;
            transform1.eulerAngles = eulerAngles;

            // Check borders
            var angles = eulerAngles;
            if (angles.x > maxAngle && angles.x <= 180f) angles.x = maxAngle;
            if (angles.x < 360f - maxAngle && angles.x > 180f) angles.x = 360f - maxAngle;
            if (angles.z > maxAngle && angles.z <= 180f) angles.z = maxAngle;
            if (angles.z < 360f - maxAngle && angles.z > 180f) angles.z = 360f - maxAngle;
            transform.eulerAngles = angles;

            // if (!Input.GetMouseButton(0)) return;
            //
            // //var vel = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            // var p = Input.mousePosition;
            // //p.y *= -1f;
            // //p.x = Mathf.Clamp(p.x, -angle, angle);
            // //p.y = Mathf.Clamp(p.y, -angle, angle);
            // p.z = p.y;
            // p.y = 0f;
            // var vel = Camera.main.ScreenToWorldPoint(p);
            // var xTemp = vel.x / (Screen.height) - Screen.height * 0.5f;
            // vel.x = vel.z / Screen.width;
            // vel.z = xTemp;
            // vel.y = 0f;
            // Debug.Log(vel);
            // _rb.MoveRotation(Quaternion.Euler(vel * angle));
        }
    }
}
