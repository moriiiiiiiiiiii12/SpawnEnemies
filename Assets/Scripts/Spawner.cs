using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _spawnInterval = 2f;
    [SerializeField] private SpawnPointData[] _spawnPoints;

    private void Start() => StartCoroutine(Spawn());

    private IEnumerator Spawn()
    {
        bool isSpawn = true;
        int minNumSpawnPoint = 0;
        int maxNumSpawnPoint = _spawnPoints.Length;

        while (isSpawn)
        {
            int randomNumSpawnPoint = Random.Range(minNumSpawnPoint, maxNumSpawnPoint);

            Vector3 spawnPoint = _spawnPoints[randomNumSpawnPoint].SpawnPoint;
            Transform target = _spawnPoints[randomNumSpawnPoint].Target;
            Enemy enemy = _spawnPoints[randomNumSpawnPoint].PrefabEnemy;

            Enemy newEnemy = Instantiate(enemy);
            newEnemy.Init(spawnPoint, target);

            yield return new WaitForSeconds(_spawnInterval);
        }
    }
}
