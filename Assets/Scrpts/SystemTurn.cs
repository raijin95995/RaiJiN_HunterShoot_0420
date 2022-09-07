using UnityEngine;
using UnityEngine.Events;
using TMPro;

namespace RAIJIN
{
	/// <summary>
	/// ╰参
	/// </summary>
	public class SystemTurn : MonoBehaviour
	{

		#region 戈
		private SystemControl systemControl;
		private SystemSpawn systemSpawn;
		private RecycleArea recycleArea;

		private int totalCountBullets;  //祇甮紆羆计
		private int totalCountEnemysLive; //ぶン

		private int totalRecycleBullets;

		public UnityEvent onTurnEnemy;

		private bool canSpawn = true;  //ネ┣

		private int countEatBullet;

		private TextMeshProUGUI textFloorCount;

		private int countFloor = 1;

		#endregion

		private void Awake()
		{
			systemControl = GameObject.Find("").GetComponent<SystemControl>();
			systemSpawn = GameObject.Find("ネ┣╰参").GetComponent<SystemSpawn>();
			recycleArea = GameObject.Find("Μ跋办").GetComponent<RecycleArea>();
			textFloorCount = GameObject.Find("糷计 计").GetComponent<TextMeshProUGUI>();

			recycleArea.onRecyele.AddListener(RecycleBullet);
		}

		#region よ猭
		private void RecycleBullet()
		{
			totalCountBullets = systemControl.howManyCanShootBullet;

			totalRecycleBullets++;
			print("紆ㄓ:" + totalRecycleBullets);

			if (totalRecycleBullets == totalCountBullets)
			{
				print("turn over");
				onTurnEnemy.Invoke();

				if (FindObjectsOfType<SystemMove>().Length == 0)
				{
					Invoke("MoveEndSpawnEnemy", 1f);

				}

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

			systemControl.howManyCanShootBullet += countEatBullet;
			countEatBullet = 0;

			int bulletTotal = systemControl.howManyCanShootBullet;

			systemControl.textBulletCount.text = "x" + bulletTotal;  //秨﹍ 陪ボヘ玡羆计  

			countFloor++;
			textFloorCount.text = countFloor.ToString();
		}



		public void EatBullet()
		{
			countEatBullet++;
		}
		#endregion





	}

}

