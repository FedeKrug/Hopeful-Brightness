using Game.Interfaces;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{

	

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<Collectable>() != null)
		{
			collision.GetComponent<Collectable>().Collect();
		}
		if (collision.GetComponent<Interactable>() != null)
		{
			collision.GetComponent<Interactable>().Interact();
		}
	}
}
