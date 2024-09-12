using ShootSystem;
using UnityEngine;

namespace PlayerSystem
{
	public class PlayerInvoker
	{
		private Player _player;
		private PlayerMovement _playerMovement;
		private PlayerCombat _playerCombat;

		public void Construct(Player player, PlayerMovement playerMovement, PlayerCombat playerCombat)
		{
			_player = player;
			_playerMovement = playerMovement;
			_playerCombat = playerCombat;
		}

		public void InvokeMove(Vector3 moveVector)
		{
			_playerMovement.Move(moveVector * _player.MovementSpeed);
		}

		public void InvokeJump()
		{
			_playerMovement.Jump(_player.JumpForce);
		}

		public void InvokeRotate(Vector2 rotateVector)
		{
			_playerMovement.Rotate(rotateVector * _player.RotationSpeed);
		}

		public void InvokeDisableMovement()
		{
			if (_playerMovement.CanControl)
				_playerMovement.SwitchMovementControl();
		}

		public void InvokeEnableMovement()
		{
			if (!_playerMovement.CanControl)
				_playerMovement.SwitchMovementControl();
		}

		public void InvokeShoot()
		{
			if (!_playerMovement.CanControl)
				return;

			_playerCombat.Shoot(_player.BulletPrefab, _player.BulletSpawnPoint);
		}
	}
}