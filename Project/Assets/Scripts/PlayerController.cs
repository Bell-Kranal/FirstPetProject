using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _turnSpeed;
    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        transform.Rotate(Vector3.up, _turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
