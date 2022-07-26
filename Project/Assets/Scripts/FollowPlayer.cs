using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position;
    }

    private void LateUpdate()
    {
        transform.position = _playerTransform.position + _offset;
    }
}
