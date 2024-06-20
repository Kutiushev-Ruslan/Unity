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
        WaitForSeconds delay =  new WaitForSeconds(_spawnInterval);

        while (_spawnEnemies)
        {
            int spawnPointIndex = Random.Range(0, _spawnPoints.Length);
            Transform spawnPoint = _spawnPoints[spawnPointIndex];

            Enemy newEnemy = Instantiate(_enemyPrefab, spawnPoint.position, Quaternion.identity);

            Quaternion gazeDirection = spawnPoint.rotation;
            Vector3 moveDirection = spawnPoint.forward;

            newEnemy.SetMoveDirection(gazeDirection, moveDirection);

            yield return delay;
        }
    }
}