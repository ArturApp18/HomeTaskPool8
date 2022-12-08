using System;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

namespace Game.Scripts
{
    public class CueController : MonoBehaviour
    {
        [SerializeField] private GameObject whiteBall;
        [SerializeField] private float hitSpeed;

        private void Start()
        {
            transform.position = whiteBall.transform.position;
        }
    }
}
