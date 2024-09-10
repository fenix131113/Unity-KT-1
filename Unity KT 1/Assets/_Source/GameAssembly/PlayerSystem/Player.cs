using UnityEngine;

namespace PlayerSystem
{
    [RequireComponent(typeof(Rigidbody))]
    public class Player : MonoBehaviour
    {
        [field: SerializeField] public float MovementSpeed { get; private set; }
        [field: SerializeField] public Rigidbody RB { get; private set; }
        [field: SerializeField] public float rotationSpeed { get; private set; }
        [field: SerializeField] public float JumpForce { get; private set; }

        private void Awake()
        {
            RB = GetComponent<Rigidbody>();
        }
    }
}