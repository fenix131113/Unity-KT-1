using System;
using PlayerSystem.View;
using UnityEngine;

namespace PlayerSystem
{
	public class PlayerMovement
	{
		public bool CanControl { get; private set; } = true;
		private readonly Rigidbody _rb;
		
		public event Action OnControlStateChanged;

		public PlayerMovement(Rigidbody playerRb)
		{
			_rb = playerRb;

			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}

		public void Move(Vector3 movement)
		{
			if (!CanControl)
				return;

			Vector3 velocity = _rb.transform.forward * movement.z + _rb.transform.right * movement.x;
			_rb.velocity = new Vector3(velocity.x, _rb.velocity.y, velocity.z);
		}

		public void Jump(float jumpForce)
		{
			if (!CanControl)
				return;

			_rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
		}

		public void Rotate(Vector3 rotation)
		{
			if (!CanControl)
				return;

			_rb.transform.Rotate(new Vector3(0, rotation.x, 0));
		}

		public void SwitchMovementControl()
		{
			CanControl = !CanControl;
			OnControlStateChanged?.Invoke();
		}
	}
}