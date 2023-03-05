using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.SO;
public class PlayerManager : MonoBehaviour
{
    public FloatSO playerHealth;
    
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
       // EventManager.instance.healthUIEvent.Invoke(playerHealth.value);
	}
    public void IncreaseHealthHandler(float healthPoints)
    {
        playerHealth.value += healthPoints;
      //  EventManager.instance.healthUIEvent.Invoke(playerHealth.value);
    }
}
