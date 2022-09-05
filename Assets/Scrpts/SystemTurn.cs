using UnityEngine;
using UnityEngine.Events;

namespace RAIJIN
{
	/// <summary>
	/// ╰参
	/// </summary>
	public class SystemTurn : MonoBehaviour
	{
		private SystemControl systemControl;
		private SystemSpawn systemSpawn;
		private RecycleArea recycleArea;

		private int totalCountBullets;  //祇甮紆羆计
		private int totalCountEnemysLive; //ぶン

		private int totalRecycleBullets;

		public UnityEvent onTurnEnemy;

		private bool canSpawn = true;  //ネ┣

		private int countEatBullet;


		private void Awake()
		{
			systemControl = GameObject.Find("").GetComponent<SystemControl>();
			systemSpawn = GameObject.Find("ネ┣╰参").GetComponent<SystemSpawn>();
			recycleArea = GameObject.Find("Μ跋办").GetComponent<RecycleArea>();

			recycleArea.onRecyele.AddListener(RecycleBullet);
		}


		private void RecycleBullet()
		{
			totalCountBullets = systemControl.howManyCanShootBullet;

			totalRecycleBullets++;
			print("紆ㄓ:" + totalRecycleBullets);

			if (totalRecycleBullets == totalCountBullets)
			{
				print("turn over");
				onTurnEnemy.Invoke();
			}
		}

		public void MoveEndSpawnEnemy()
		{
			if (!canSpawn) return;
			canSpawn = false;
			systemSpawn.SpawnRandom();
			Invoke("PlayerTurn", 1f);



		}

		public void PlayerTurn()
		{
			systemControl.canShootBullet = true;
			canSpawn = true;
			totalRecycleBullets = 0;
		}



		public void EatBullet()
		{
			countEatBullet++;
		}






	}

}

