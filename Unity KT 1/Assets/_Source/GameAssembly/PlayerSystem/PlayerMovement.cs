using UnityEngine;

namespace PlayerSystem
{
	public class PlayerMovement
	{
		public bool CanControl { get; private set; } = true;
		private readonly Rigidbody _rb;

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

			Vector3 veclocity = _rb.transform.forward * movement.z + _rb.transform.right * movement.x;
			_rb.velocity = new Vector3(veclocity.x, _rb.velocity.y, veclocity.z);
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

		public void SwitchMovementControl(GameObject controlMessage)
		{
			CanControl = !CanControl;
			controlMessage.SetActive(!CanControl);
		}
	}
}