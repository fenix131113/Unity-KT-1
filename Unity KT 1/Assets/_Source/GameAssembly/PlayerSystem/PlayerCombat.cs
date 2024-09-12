using UnityEngine;

namespace PlayerSystem
{
	public class PlayerCombat
	{
		public void Shoot(GameObject bulletPrefab, Transform bulletSpawnPoint)
		{
			Object.Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
		}
	}
}
