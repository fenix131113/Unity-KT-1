using InputSystem;
using PlayerSystem;
using PlayerSystem.View;
using ShootSystem;
using UnityEngine;

namespace Core
{
	public class Bootstrapper : MonoBehaviour
	{
		[SerializeField] private InputListener inputListener;
		[SerializeField] private Player player;
		[SerializeField] private PlayerHUD playerHud;
		
		private PlayerMovement _playerMovement;
		
		private readonly PlayerCombat _playerCombat = new();
		private readonly PlayerInvoker _invoker = new();

		private void Awake()
		{
			_playerMovement = new PlayerMovement(player.Rb);
			
			_invoker.Construct(player, _playerMovement, _playerCombat);
			inputListener.Construct(_invoker);
			playerHud.Construct(_playerMovement);
		}
	}
}
