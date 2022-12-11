using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

namespace Game.Scripts
{
    public class Cue : MonoBehaviour
    {
        [SerializeField] private WhiteBall _whiteBall;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private float _hitPower;

        private void Start()
        {
            transform.position = _whiteBall.transform.position;
        }

        private void Update()
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.y = transform.position.y;
            Vector3 relativePos = mousePos - _whiteBall.transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos);
            transform.rotation = rotation;

            if (Input.GetMouseButtonUp(0) && !_whiteBall.isMoving)
            {
                Hit();
            }

            if (_whiteBall.isMoving)
            {
                _spriteRenderer.enabled = false;
            }
            else
            {
                transform.position = _whiteBall.transform.position;
                _spriteRenderer.enabled = true;
            }
        }

        private void Hit()
        {
            Vector3 heading = _whiteBall.transform.position - transform.position;
            float distance = heading.magnitude;
            Vector3 direction = heading / distance;
            
            _rigidbody.AddForce(transform.forward * _hitPower, ForceMode.Impulse);
        }
    }
}
