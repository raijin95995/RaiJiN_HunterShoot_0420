using UnityEngine;
using UnityEngine.Events;

namespace RAIJIN
{
	/// <summary>
	/// 回合系統
	/// </summary>
	public class SystemTurn : MonoBehaviour
	{
		private SystemControl systemControl;
		private SystemSpawn systemSpawn;
		private RecycleArea recycleArea;

		private int totalCountBullets;  //發射子彈總數
		private int totalCountEnemysLive; //回合後多少物件存活

		private int totalRecycleBullets;

		public UnityEvent onTurnEnemy;

		private bool canSpawn = true;  //生怪限制

		private int countEatBullet;


		private void Awake()
		{
			systemControl = GameObject.Find("狗狗").GetComponent<SystemControl>();
			systemSpawn = GameObject.Find("生怪系統").GetComponent<SystemSpawn>();
			recycleArea = GameObject.Find("回收區域").GetComponent<RecycleArea>();

			recycleArea.onRecyele.AddListener(RecycleBullet);
		}


		private void RecycleBullet()
		{
			totalCountBullets = systemControl.howManyCanShootBullet;

			totalRecycleBullets++;
			print("子彈回來了:" + totalRecycleBullets);

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

