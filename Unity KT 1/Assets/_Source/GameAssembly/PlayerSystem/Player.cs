using UnityEngine;

namespace PlayerSystem
{
    [RequireComponent(typeof(Rigidbody))]
    public class Player : MonoBehaviour
    {
        [field: SerializeField] public float MovementSpeed { get; private set; }
        [field: SerializeField] public Rigidbody Rb { get; private set; }
        [field: SerializeField] public float RotationSpeed { get; private set; }
        [field: SerializeField] public float JumpForce { get; private set; }
        [field: SerializeField] public GameObject StoppedMovementMessage { get; private set; }
        [field: SerializeField] public GameObject BulletPrefab { get; private set; }

        private void Awake()
        {
            Rb = GetComponent<Rigidbody>();
        }
    }
}