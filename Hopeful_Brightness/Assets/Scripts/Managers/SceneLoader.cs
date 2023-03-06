using System.Collections;
using System.Collections.Generic;

using Game.SO;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
	[SerializeField] private FloatSO _playerHealth;
	public void ChangeScene(string scene)
	{
		Time.timeScale = 0;
		_playerHealth.value = UIManager.instance.maxHealth;
		SceneManager.LoadScene(scene);
	}

	public void ReloadScene()
	{
		Time.timeScale = 0;
		_playerHealth.value = UIManager.instance.maxHealth;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	public void SetTimeScale(int timeScale)
	{
		Time.timeScale = timeScale;
	}
}
