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
	[SerializeField] private GameObject _winScreen;
	[SerializeField] private float _timeOfCinematic;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			_director.Play();
			_playerRef.enabled = false;
			_playerJumpRef.enabled = false;
			StartCoroutine(ShowWinScreen());
		}
	}
	IEnumerator ShowWinScreen()
	{
		yield return new WaitForSeconds(_timeOfCinematic);
		_winScreen.SetActive(true);
	}
}
