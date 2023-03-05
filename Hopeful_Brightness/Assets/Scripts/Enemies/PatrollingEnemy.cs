
using UnityEngine;


namespace Game.Enemies
{
	public class PatrollingEnemy : Enemy
	{
		[SerializeField] private bool _onLimit;
		[SerializeField] private float _minSpeed, _maxSpeed;
		[SerializeField] private SpriteRenderer _spriteR;
		private void Awake()
		{
			movementSpeed = _minSpeed;
		}
		private void Update()
		{
			if (_onLimit)
			{
				movementSpeed = _maxSpeed;
				_spriteR.flipX = true;
			}
			else
			{
				movementSpeed = _minSpeed;
				_spriteR.flipX = false;
			}
		}
		private void FixedUpdate()
		{
			rb2d.velocity = new Vector2(movementSpeed * Time.deltaTime, rb2d.velocity.y);
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.CompareTag("Limit"))
			{
				_onLimit = !_onLimit;
			}

			
		}
	}
}