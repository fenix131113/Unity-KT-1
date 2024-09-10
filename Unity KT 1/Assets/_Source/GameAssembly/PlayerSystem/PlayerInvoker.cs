namespace PlayerSystem
{
    public class PlayerInvoker
    {
        private PlayerMovement _playerMovement;
        private Player _player;

        public PlayerInvoker()
        {
            _playerMovement = new();
        }

        public void InvokeJump()
        {
            _playerMovement.Jump(_player.RB, _player.JumpForce);
        }
    }
}