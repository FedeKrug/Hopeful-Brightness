using Game.Player;

using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Playables;

public class WinEvent : MonoBehaviour
{
	[SerializeField] PlayableDirector _director;
	[SerializeField] PlayerMovement _playerRef;
	[SerializeField] PlayerJump _playerJumpRef;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			_director.Play();
			_playerRef.enabled = false;
			_playerJumpRef.enabled = false;
		}
	}
}
