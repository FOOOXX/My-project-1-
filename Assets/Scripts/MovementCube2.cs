using UnityEngine;

public class MovementCube2 : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody _rigidbody;
    private Vector3 _targetScale;
    private float _titleAngle;
    private float _sizeIncreaseFactor = 1;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _rigidbody.velocity = transform.right * _speed;

        _titleAngle++;
        Quaternion rotateY = Quaternion.AngleAxis(_titleAngle, Vector3.up);
        _rigidbody.MoveRotation(rotateY);

        _targetScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        _sizeIncreaseFactor += 0.0001f;
        transform.localScale = Vector3.Lerp(transform.localScale, _targetScale * _sizeIncreaseFactor, _speed * Time.deltaTime);
    }
}
