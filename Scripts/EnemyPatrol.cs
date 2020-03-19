using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private Vector3 _endPosition;
    [SerializeField] private float _speed=2;
    private float step;
    private Vector3 _target;
    private void Start()
    {
        transform.position = _startPosition;
        _target = _endPosition;
    }
    private void Update()
    {
        step = _speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, _target, step);
        
        if (transform.position == _endPosition)
            _target = _startPosition;

        if (transform.position == _startPosition)
            _target = _endPosition;
    }
}
