using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private Vector3 _direction;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        Move();
    }

    public void Init(Transform transform, Vector3 direction)
    {
        this.transform.position = transform.position;
        _direction = direction.normalized;

        gameObject.SetActive(true);
    }

    public void Move()
    {
        transform.Translate(_direction * speed * Time.deltaTime);
    }
}
