using UnityEngine;


namespace RAIJIN
{

	/// <summary>
	/// 吃子彈系統
	/// </summary>
	public class SystemEatBullet : MonoBehaviour
	{
		private string nameBullet = "子彈";
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
