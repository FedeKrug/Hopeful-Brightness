
using UnityEngine;


namespace Game.Enemies
{
	public class Spike : Obstacle
	{
		protected override void MakeDamage()
		{
			base.MakeDamage();
			Debug.Log($"Spike's idleDamage is: {idleDamage}");
		}
	}
}