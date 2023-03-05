using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.SO;
public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public FloatSO playerHealth;

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


	void Update()
    {
        
    }

    public void TakeDamageHandler(float damage)
	{
        playerHealth.value -= damage;
	}
    public void IncreaseHealthHandler(float healthPoints)
    {
        PlayerManager.instance.playerHealth.value += healthPoints;
    }
}
