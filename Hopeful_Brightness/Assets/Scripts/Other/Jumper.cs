using Game.Player;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
	[SerializeField] private float _jumpForce;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<PlayerJump>())
		{
			collision.GetComponent<PlayerJump>().Jump(_jumpForce);
		}
	}
}
