using System.Collections;
using System.Collections.Generic;

using UnityEngine;


namespace Game.Player
{
	public class PlayerMovement : MonoBehaviour
	{
		[SerializeField, Range(0, 100)] private float _movementSpeed;
		[SerializeField] private Rigidbody2D _rb2d;
		[SerializeField] private SpriteRenderer _spriteR;
		[SerializeField] private Animator _anim;
		private Vector2 _moveInput;
		void Awake()
		{

		}
		private void Update()
		{
			_moveInput.x = Input.GetAxis("Horizontal");
			if (_moveInput.x < 0)
			{
				_spriteR.flipX = true;
				_anim.SetBool("IsRunning", true);
			}
			else if(_moveInput.x > 0)
			{
				_spriteR.flipX = false;
				_anim.SetBool("IsRunning", true);
			}
			if (_moveInput.x ==0)
			{
				_anim.SetBool("IsRunning", false);
			}
			
		}

		void FixedUpdate()
		{
			Move();
		}

		private void Move()
		{
			_rb2d.velocity = new Vector2(_moveInput.x * _movementSpeed * Time.fixedDeltaTime, _rb2d.velocity.y);
		}
	}
}

