using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
	[SerializeField] private Image _healthBar;
	[SerializeField] private float _maxHealth; 
	#region Singleton & Suscribe / Unsuscribe Events
	public static UIManager instance;
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
		EventManager.instance.healthUIEvent.AddListener(HealthUIHandler);
	}
	private void OnDisable()
	{
		EventManager.instance.healthUIEvent.RemoveListener(HealthUIHandler);
	}
	#endregion

	public void HealthUIHandler( float playerHealth)
	{
		_healthBar.fillAmount = playerHealth/_maxHealth;
	}

	

}
