using System;
using UnityEngine;

namespace ShootSystem
{
	public class Bullet : MonoBehaviour
	{
		[SerializeField] private float speed;
		[SerializeField] private float lifetime;

		private void Start()
		{
			Destroy(gameObject, lifetime);
		}

		private void Update()
		{
			transform.position += transform.forward * (speed * Time.deltaTime);
		}

		private void OnTriggerEnter(Collider other)
		{
			Destroy(gameObject);
		}
	}
}
