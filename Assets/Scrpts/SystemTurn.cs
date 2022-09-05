using UnityEngine;
using UnityEngine.Events;

namespace RAIJIN
{
	/// <summary>
	/// �^�X�t��
	/// </summary>
	public class SystemTurn : MonoBehaviour
	{
		private SystemControl systemControl;
		private SystemSpawn systemSpawn;
		private RecycleArea recycleArea;

		private int totalCountBullets;  //�o�g�l�u�`��
		private int totalCountEnemysLive; //�^�X��h�֪���s��

		private int totalRecycleBullets;

		public UnityEvent onTurnEnemy;

		private bool canSpawn = true;  //�ͩǭ���

		private int countEatBullet;


		private void Awake()
		{
			systemControl = GameObject.Find("����").GetComponent<SystemControl>();
			systemSpawn = GameObject.Find("�ͩǨt��").GetComponent<SystemSpawn>();
			recycleArea = GameObject.Find("�^���ϰ�").GetComponent<RecycleArea>();

			recycleArea.onRecyele.AddListener(RecycleBullet);
		}


		private void RecycleBullet()
		{
			totalCountBullets = systemControl.howManyCanShootBullet;

			totalRecycleBullets++;
			print("�l�u�^�ӤF:" + totalRecycleBullets);

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

