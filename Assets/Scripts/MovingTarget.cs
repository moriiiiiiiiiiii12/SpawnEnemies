using UnityEngine;

class MovingTarget : MonoBehaviour
{
    [SerializeField] private float _speed = 20f;
    [SerializeField] private Transform[] _marshoutPoints;
    [SerializeField] private int _numCurrentPoint = 0;

    private void Update()
    {
        float arrivalDistance = 0.2f;

        if (Vector3.Distance(transform.position, _marshoutPoints[_numCurrentPoint].position) < arrivalDistance)
        {
            if (_marshoutPoints.Length - 1 > _numCurrentPoint)
                _numCurrentPoint++;
            else
                _numCurrentPoint = 0;

        }

        Move();
    }

    private void Move()
    {
        Vector3 direction = (_marshoutPoints[_numCurrentPoint].position - transform.position).normalized;

        transform.LookAt(_marshoutPoints[_numCurrentPoint]);
        transform.Translate(direction * _speed * Time.deltaTime, Space.World);
    }
}

