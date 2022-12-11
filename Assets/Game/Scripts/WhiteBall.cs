using UnityEngine;

namespace Game.Scripts
{
    public class WhiteBall : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _ballSpeed;

        public bool isMoving;

        private void Update()
        {
            _ballSpeed = _rigidbody.velocity.magnitude;
            if (_ballSpeed > 0)
            {
                isMoving = true;
            }
            else
            {
                isMoving = false;
                
            }
        }
    }
}
