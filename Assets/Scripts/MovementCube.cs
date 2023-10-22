using UnityEngine;

public class MovementCube : MonoBehaviour
{
    private float _titleAngle;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _titleAngle++;

        Quaternion rotationY = Quaternion.AngleAxis(_titleAngle, Vector3.up);

        _rigidbody.MoveRotation(rotationY);
    }
}
