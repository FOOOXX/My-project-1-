using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MovementCapsule : MonoBehaviour
{
    [SerializeField] private int _speed;

    private float _sizeIncreaseFactor = 1;
    private Vector3 _targetScale;

    private void Update()
    {
        _targetScale = new Vector3(transform.localScale.x * _sizeIncreaseFactor, transform.localScale.y * _sizeIncreaseFactor, transform.localScale.z * _sizeIncreaseFactor);

        _sizeIncreaseFactor += 0.0001f;

        transform.localScale = Vector3.Lerp(transform.localScale, _targetScale, Time.deltaTime * _speed);
    }
}
