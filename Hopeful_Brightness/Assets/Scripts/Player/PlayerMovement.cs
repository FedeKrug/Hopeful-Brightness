using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;

namespace Game.Player
{
	public class PlayerMovement : MonoBehaviour
	{
		[SerializeField, Range(0, 500)] private float _movementSpeed;
		public  Rigidbody2D rb2d;
		[SerializeField] private SpriteRenderer _spriteR;
		[SerializeField] private Animator _anim;
		[SerializeField] private string  _deathAnimation;
		[SerializeField] private AudioSource _aSource;
		[SerializeField] private AudioClip _hurtSound, _deathSound;
		[SerializeField] private float _timeOfInvencible;
		[SerializeField] private GameObject _looseScreen;

		private bool _dead;
		private Vector2 _moveInput;

		private void Update()
		{
			_moveInput.x = Input.GetAxis("Horizontal");
			if (_moveInput.x < 0)
			{
				_spriteR.flipX = true;
				_anim.SetBool("IsRunning", true);
			}
			else if (_moveInput.x > 0)
			{
				_spriteR.flipX = false;
				_anim.SetBool("IsRunning", true);
			}
			if (_moveInput.x == 0)
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
			rb2d.velocity = new Vector2(_moveInput.x * _movementSpeed * Time.fixedDeltaTime, rb2d.velocity.y);
		}
		public void Hurt()
		{
			StartCoroutine(HurtBehaiviours());
		}
		public void Death()
		{
			if (!_dead)
			{
				StartCoroutine(Die());

			}
			else return;
		}

		IEnumerator Die()
		{

			yield return null;
			_anim.Play(_deathAnimation);
			_aSource.PlayOneShot(_deathSound);
			_dead = true;
			yield return new WaitForSeconds(0.8f);
			_looseScreen.SetActive(true);
			Time.timeScale = 0;
		}

		IEnumerator HurtBehaiviours()
		{
			yield return null;
			_aSource.PlayOneShot(_hurtSound);
			gameObject.layer = 9; //TODO: cambiar a una layer invencible
			_spriteR.enabled = false;
			yield return null;
			_spriteR.enabled = true;
			while (_aSource.isPlaying)
			{
				yield return null;

			}
			_spriteR.enabled = true;
			yield return new WaitForSeconds(_timeOfInvencible);
			gameObject.layer = 8; //TODO: buscar la layer del player y cambiar este 0


		}

	}
}
