using UnityEngine;

namespace ShootingSystem
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private float velocity;
        private Rigidbody2D _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            _rb.velocity = transform.right * velocity;
        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}