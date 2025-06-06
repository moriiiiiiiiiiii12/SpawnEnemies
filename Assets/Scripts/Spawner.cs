using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefabEnemy;
    [SerializeField] private float _spawnInterval = 2f;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start() => StartCoroutine(Spawn());

    private IEnumerator Spawn()
    {
        bool isSpawn = true;

        while (isSpawn)
        {
            int randomNumSpawnPoint = Random.Range(0, _spawnPoints.Length);
            Transform randomSpawnPoint = _spawnPoints[randomNumSpawnPoint];

            Enemy newEnemy = Instantiate(_prefabEnemy);

            newEnemy.Init(randomSpawnPoint, GetRandomDirection());

            yield return new WaitForSeconds(_spawnInterval);
        }
    }

    private Vector3 GetRandomDirection()
    {
        float minValue = -1f;
        float maxValue = 1f;

        float randomX = Random.Range(minValue, maxValue);
        float randomZ = Random.Range(minValue, maxValue);
        float y = 0f;

        return new Vector3(randomX, y, randomZ);
    }
}
