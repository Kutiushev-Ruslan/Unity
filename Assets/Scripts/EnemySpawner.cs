using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;

    private bool _spawnEnemies = true;
    private float _spawnInterval = 2f;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (_spawnEnemies)
        {
            int spawnPointIndex = Random.Range(0, _spawnPoints.Length);
            Transform spawnPoint = _spawnPoints[spawnPointIndex];

            Enemy newEnemy = Instantiate(_enemyPrefab, spawnPoint.position, Quaternion.identity);

            Quaternion moveDirection = spawnPoint.rotation;

            newEnemy.SetMoveDirection(moveDirection);

            yield return new WaitForSeconds(_spawnInterval);
        }
    }
}