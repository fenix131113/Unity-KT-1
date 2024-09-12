using PlayerSystem;
using UnityEngine;

namespace InputSystem
{
	public class InputListener : MonoBehaviour
	{
		private PlayerInvoker _invoker;

		public void Construct(PlayerInvoker playerInvoker)
		{
			_invoker = playerInvoker;
		}

		private void Update()
		{
			ReadJumpInput();
			ReadMoveInput();
			ReadCameraInput();
			ReadDisableMovement();
			ReadEnableMovement();
			ReadShootInput();
		}

		private void ReadShootInput()
		{
			if (Input.GetKeyDown(KeyCode.Q))
				_invoker.InvokeShoot();
		}

		private void ReadDisableMovement()
		{
			if (Input.GetKeyDown(KeyCode.Return))
				_invoker.InvokeDisableMovement();
		}

		private void ReadEnableMovement()
		{
			if (Input.GetMouseButtonDown(0))
				_invoker.InvokeEnableMovement();
		}

		private void ReadCameraInput()
		{
			Vector2 rotateVector = new Vector2(Input.GetAxis("Mouse X"), 0);

			if (rotateVector.magnitude > 0)
				_invoker.InvokeRotate(rotateVector);
		}

		private void ReadJumpInput()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				_invoker.InvokeJump();
			}
		}

		private void ReadMoveInput()
		{
			Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

			if (input.magnitude > 0)
				_invoker.InvokeMove(input);
		}
	}
}