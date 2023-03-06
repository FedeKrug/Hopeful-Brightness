using Game.Player;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
	[SerializeField] private PlayerMovement _playerRef;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			_playerRef.Death();
		}
		else
		{
			Destroy(collision.gameObject);
		}
	}
}
