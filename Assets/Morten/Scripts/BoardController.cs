using UnityEngine;

public class BoardController : MonoBehaviour
{
    [SerializeField] private int rotationSpeed;
    [SerializeField] private int maxAngle;

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        RotateBoard();
    }

    private void RotateBoard()
    {
        var horizontalRot = Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.fixedDeltaTime;
        var verticalRot = Input.GetAxisRaw("Vertical") * rotationSpeed * Time.fixedDeltaTime;

        var angles = transform.rotation.eulerAngles;
        angles.z -= horizontalRot;
        angles.x += verticalRot;

        if (angles.x > maxAngle && angles.x <= 180f)
        {
            angles.x = maxAngle;
        }

        if (angles.x < 360f - maxAngle && angles.x > 180f)
        {
            angles.x = 360f - maxAngle;
        }

        if (angles.z > maxAngle && angles.z <= 180f)
        {
            angles.z = maxAngle;
        }

        if (angles.z < 360f - maxAngle && angles.z > 180f)
        {
            angles.z = 360f - maxAngle;
        }

        _rb.MoveRotation(Quaternion.Euler(angles));
    }
}
