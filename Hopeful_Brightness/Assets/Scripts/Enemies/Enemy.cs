using System.Collections;
using System.Collections.Generic;

using UnityEngine;


namespace Game.Enemies
{
	public abstract class Enemy : MonoBehaviour
	{
		[SerializeField] protected float damage;
		[SerializeField] protected float movementSpeed;
		[SerializeField] protected Transform playerRef;
		[SerializeField] protected Rigidbody2D rb2d;
	}
}