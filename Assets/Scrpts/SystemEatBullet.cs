using UnityEngine;


namespace RAIJIN
{
	public class SystemEatBullet : MonoBehaviour
	{
		private string nameBullet = "�l�u";


		private void OnTriggerEnter(Collider other)
		{
			if (other.name.Contains(nameBullet))
			{
				Destroy(gameObject);

			}
		}


	}

}
