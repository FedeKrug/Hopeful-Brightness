
using UnityEngine;


namespace Game.Player
{
	public class FloorDetector : MonoBehaviour
	{
		public bool floorDetected;
		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.CompareTag("Platform"))
			{
				floorDetected = true;
			}
		}
		private void OnTriggerExit2D(Collider2D collision)
		{
			if (collision.CompareTag("Platform"))
			{
				floorDetected = false;

			}
		}
	}
}

