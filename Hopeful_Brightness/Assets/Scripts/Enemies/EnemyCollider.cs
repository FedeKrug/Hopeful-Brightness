
using UnityEngine;


namespace Game.Enemies
{
	public class EnemyCollider : MonoBehaviour
	{
		[SerializeField] private float _damage;

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.CompareTag("Player"))
			{
				PlayerManager.instance.TakeDamageHandler(_damage);
			}
		}
	}
}