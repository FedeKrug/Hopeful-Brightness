
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
	#region Singleton
	public static EventManager instance;
	private void Awake()
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
	#endregion


	public HealthEvent hurtPlayerEvent = new HealthEvent();
	public HealthEvent increaseHealthEvent = new HealthEvent();
}

public class HealthEvent : UnityEvent <float>{ }