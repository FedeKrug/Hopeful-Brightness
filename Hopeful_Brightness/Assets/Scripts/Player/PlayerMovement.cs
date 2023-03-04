using System.Collections;
using System.Collections.Generic;

using UnityEngine;


namespace Game.Player
{
	public class PlayerMovement : MonoBehaviour
	{
		[SerializeField, Range(0,100)] private float _movementSpeed;
		[SerializeField] private Rigidbody2D _rb2d;
		[SerializeField] private SpriteRenderer _spriteR;
		private Vector2 _moveInput;
		void Awake()
		{

		}
		private void Update()
		{
			_moveInput.x = Input.GetAxis("Horizontal");
			if (_moveInput.x<0)
			{
				_spriteR.flipX = true;
			}
			else
			{
				_spriteR.flipX = false;
			}
		}

		void FixedUpdate()
		{

			_rb2d.velocity = new Vector2(_moveInput.x * _movementSpeed * Time.fixedDeltaTime,_rb2d.velocity.y);
		}
	}
}

