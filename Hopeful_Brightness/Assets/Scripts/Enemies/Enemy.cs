using System.Collections;
using System.Collections.Generic;

using UnityEngine;


namespace Game.Enemies
{
	public abstract class Enemy : MonoBehaviour
	{
		[SerializeField] protected float damage;
		[SerializeField] protected Transform playerRef;


	}
}