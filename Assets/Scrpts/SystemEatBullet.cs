using UnityEngine;


namespace RAIJIN
{

	/// <summary>
	/// �Y�l�u�t��
	/// </summary>
	public class SystemEatBullet : MonoBehaviour
	{
		private string nameBullet = "�l�u";
		private SystemTurn systemTurn;


		private void Awake()
		{

			systemTurn = FindObjectOfType<SystemTurn>();

		}



		private void OnTriggerEnter(Collider other)
		{


			if (other.name.Contains(nameBullet))
			{
				systemTurn.EatBullet();
				Destroy(gameObject);

			}
		}


	}

}
