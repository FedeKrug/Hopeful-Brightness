using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.SO;
using Game.Player;
using System;

public class PlayerManager : MonoBehaviour
{
    public FloatSO playerHealth;
    [SerializeField] private PlayerMovement _playerRef;
    #region Singleton & Suscribe / Unsuscribe Events
    public static PlayerManager instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
		{
            Destroy(gameObject);
		}
    }

	private void OnEnable()
	{
        EventManager.instance.hurtPlayerEvent.AddListener(TakeDamageHandler);
        EventManager.instance.increaseHealthEvent.AddListener(IncreaseHealthHandler);
	}

	private void OnDisable()
	{
        EventManager.instance.hurtPlayerEvent.RemoveListener(TakeDamageHandler);
        EventManager.instance.increaseHealthEvent.RemoveListener(IncreaseHealthHandler);
    }

	#endregion


	void Update()
    {
        EventManager.instance.healthUIEvent.Invoke(playerHealth.value);
    }

    public void TakeDamageHandler(float damage)
	{
        playerHealth.value -= damage;
        _playerRef.Hurt();
        CheckDeaht();
       // EventManager.instance.healthUIEvent.Invoke(playerHealth.value);
	}

	private void CheckDeaht()
	{
		if (playerHealth.value <=0)
		{
            _playerRef.Death();
		}
	}

	public void IncreaseHealthHandler(float healthPoints)
    {
        playerHealth.value += healthPoints;
      //  EventManager.instance.healthUIEvent.Invoke(playerHealth.value);
    }
}
