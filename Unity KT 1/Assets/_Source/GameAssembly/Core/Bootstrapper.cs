using InputSystem;
using PlayerSystem;
using ShootSystem;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core
{
	public class Bootstrapper : MonoBehaviour
	{
		[SerializeField] private InputListener inputListener;
		[FormerlySerializedAs("playerShoot")] [SerializeField] private PlayerCombat playerCombat;
		[SerializeField] private Player player;
		
		private PlayerMovement _playerMovement;
		
		private readonly PlayerInvoker _invoker = new();

		private void Awake()
		{
			_playerMovement = new PlayerMovement(player.Rb);
			
			_invoker.Construct(player, _playerMovement, playerCombat);
			inputListener.Construct(_invoker);
		}
	}
}
