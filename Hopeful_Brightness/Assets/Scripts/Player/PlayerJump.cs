﻿using System.Collections;

using UnityEngine;


namespace Game.Player
{
	public class PlayerJump : MonoBehaviour
	{
		[SerializeField] float _jumpForce;
		[SerializeField] private Rigidbody2D _rb2d;
		[SerializeField] private Animator _anim;
		[SerializeField] private float _timeOfJumping;
		[SerializeField] private bool _onJump;
		[SerializeField] private bool _falling = false;

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				Jump();
			}
			//if (Input.GetKeyUp("Jump"))
			//{
			//	_onJump = false;
			//	_falling = true;
			//}
			

		}

		private void Jump()
		{
			_rb2d.AddForce(new Vector2(_rb2d.velocity.x, _rb2d.velocity.y * _jumpForce * Time.deltaTime), ForceMode2D.Impulse);
			_onJump = true;
			_falling = false;
			_anim.SetBool("OnJump", true);
			_anim.SetBool("Faliing", false);
			StartCoroutine(MakeTheJump());
		}

		IEnumerator MakeTheJump()
		{
			yield return new WaitForSeconds(_timeOfJumping);
			_onJump = false;
			_falling = true;
			yield return null;
			_anim.SetBool("OnJump", false);
			_anim.SetBool("Falling", true);
			yield return new WaitForSeconds(0.2f);
			_anim.SetBool("Falling", false);

		}
	}
}

