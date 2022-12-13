using UnityEngine;

namespace Game.Scripts
{
    public class WhiteBall : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _ballSpeed;
        [SerializeField] private float _minBallSpeed;

        public bool isMoving;

        private void Update()
        {
            _ballSpeed = _rigidbody.velocity.magnitude;
            if (_ballSpeed > _minBallSpeed)
            {
                isMoving = true;
            }
            else
            {
                isMoving = false;
                _rigidbody.velocity = Vector3.zero;
                _rigidbody.angularVelocity = Vector3.zero;
            }
        }
    }
}
