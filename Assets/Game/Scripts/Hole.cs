using System;
using UnityEngine;

namespace Game.Scripts
{
    public class Hole : MonoBehaviour
    {
        [SerializeField] private Transform _respawnPoint;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Ball"))
            {
                Destroy(other.gameObject, 0.2f);
                Debug.Log("Ball");
            }
            else if (other.gameObject.CompareTag("WhiteBall"))
            {
                other.transform.position = _respawnPoint.position;
                other.attachedRigidbody.velocity = Vector3.zero;
                Debug.Log("Whitte");
            }
        }
    }
}
