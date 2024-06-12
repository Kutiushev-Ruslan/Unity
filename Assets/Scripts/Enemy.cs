using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private void Update()
    {
        MoveEnemy();
    }

    public void SetMoveDirection(Quaternion direction)
    {
        transform.rotation = direction;
    }

    private void MoveEnemy()
    {
        Vector3 currentPosition = transform.position;
        Vector3 newPosition = currentPosition + transform.forward * Time.deltaTime * _moveSpeed;

        transform.position = newPosition;
    }
}
