using UnityEngine;


namespace RAIJIN
{
	public class SystemEatBullet : MonoBehaviour
	{
		private string nameBullet = "¤l¼u";


		private void OnTriggerEnter(Collider other)
		{
			if (other.name.Contains(nameBullet))
			{
				Destroy(gameObject);

			}
		}


	}

}
