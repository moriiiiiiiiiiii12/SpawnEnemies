using UnityEngine;

[System.Serializable]
public struct SpawnPointData
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Transform _target;
    [SerializeField] private Enemy _prefabEnemy;

    public Vector3 SpawnPoint => _spawnPoint.position;
    public Transform Target => _target;
    public Enemy PrefabEnemy => _prefabEnemy;
}