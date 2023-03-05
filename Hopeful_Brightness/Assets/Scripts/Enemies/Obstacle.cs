
using UnityEngine;


namespace Game.Enemies
{
	public abstract class Obstacle : MonoBehaviour
	{
		[SerializeField] protected float idleDamage;

		protected virtual void MakeDamage()
		{
			PlayerManager.instance.TakeDamageHandler(idleDamage);
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.CompareTag("Player"))
			{
				MakeDamage();

			}
		}
	}
}