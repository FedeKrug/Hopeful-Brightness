using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Interfaces;
public class MedicalKit : MonoBehaviour, Collectable
{

	[SerializeField] private float _healthPoints;
	[SerializeField] private AudioSource _aSource;
	[SerializeField] private SpriteRenderer _spriteR;
	[SerializeField] private AudioClip _medicalKitSound;
	[SerializeField] private GameObject _particleExplosion;
	public void Collect()
	{
		IncreaseHealth();
		StartCoroutine(CollectionEffect());
	}

	public void IncreaseHealth()
	{
		PlayerManager.instance.playerHealth.value += _healthPoints;
	}

	IEnumerator CollectionEffect()
	{
		_spriteR.enabled = false;
		_aSource.PlayOneShot(_medicalKitSound);
		gameObject.layer = 10; //TODO: create a new layer for stuff player could interact or collide
		_particleExplosion.SetActive(true);
		while (_aSource.isPlaying)
		{
			yield return null;

		}

		yield return null;
		gameObject.SetActive(false);
	}
}
