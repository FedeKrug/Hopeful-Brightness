using System.Collections;
using System.Collections.Generic;

using UnityEngine;


namespace Game.Enemies
{
	public abstract class Enemy : MonoBehaviour
	{
		
		protected float movementSpeed;
		[SerializeField] protected Rigidbody2D rb2d;
	}
}