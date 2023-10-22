using UnityEngine;

public class MovementSphere : MonoBehaviour
{
    [SerializeField] private int _speed;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
         _rigidbody.velocity = Vector3.right * _speed;
    }
}
