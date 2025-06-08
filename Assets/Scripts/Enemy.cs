using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private Transform _target;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        Move();
    }

    public void Init(Vector3 position, Transform direction)
    {
        transform.position = position;

        _target = direction;

        gameObject.SetActive(true);
    }

    public void Move()
    {
        Vector3 direction = (_target.position - transform.position).normalized;

        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
