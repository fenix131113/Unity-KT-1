using UnityEngine;

namespace ShootSystem
{
	public class PlayerCombat : MonoBehaviour
	{
		[SerializeField] private Transform bulletSpawnPoint;

		public void Shoot(GameObject bulletPrefab)
		{
			Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
		}
	}
}
