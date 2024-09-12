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

        private void Bind()
        {
            _playerMovement.OnControlStateChanged += RefreshHUD;
        }

        private void RefreshHUD()
        {
            StoppedMessage.SetActive(!_playerMovement.CanControl);
        }
    }
}
