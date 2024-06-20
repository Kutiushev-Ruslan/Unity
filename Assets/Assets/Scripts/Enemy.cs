using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    private Vector3 _moveDirection;

    private void Update()
    {
        MoveEnemy();
    }

    public void SetMoveDirection(Quaternion gazeDirection, Vector3 moveDirection)
    {
        transform.rotation = gazeDirection;
        _moveDirection = moveDirection;
    }

    private void MoveEnemy()
    {
        transform.position += _moveDirection * Time.deltaTime * _moveSpeed;
    }
}
