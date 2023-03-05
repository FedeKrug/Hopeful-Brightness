using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;

[DefaultExecutionOrder(-10)]
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

	public HealthUIEvent healthUIEvent = new HealthUIEvent();
}

public class HealthEvent : UnityEvent <float>{ }

public class HealthUIEvent : UnityEvent< float> { }