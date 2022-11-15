using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float EnemymoveSpeed;
    private void FixedUpdate()
    {
        var delta = transform.position - player.transform.position;
        delta.y = 0;
        var _direction = delta.normalized;
        _rigidbody.velocity = _direction * EnemymoveSpeed * Time.deltaTime * -1;    }
}