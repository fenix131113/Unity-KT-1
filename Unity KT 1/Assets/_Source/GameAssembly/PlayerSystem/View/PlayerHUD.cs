using UnityEngine;

namespace PlayerSystem.View
{
    public class PlayerHUD : MonoBehaviour
    {
        [field: SerializeField] public GameObject StoppedMessage { get; private set; }
        
        private PlayerMovement _playerMovement;

        public void Construct(PlayerMovement playerMovement)
        {
            _playerMovement = playerMovement;

            Bind();
        }
        
        private void RefreshHUD()
        {
            StoppedMessage.SetActive(!_playerMovement.CanControl);
        }

        private void Bind()
        {
            _playerMovement.OnControlStateChanged += RefreshHUD;
        }

        private void Expose()
        {
            _playerMovement.OnControlStateChanged -= RefreshHUD;
        }

        private void OnDestroy() => Expose();
        private void OnDisable() => Expose();
    }
}
