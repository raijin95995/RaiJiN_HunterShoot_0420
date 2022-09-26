using UnityEngine;
using UnityEngine.Events;
using TMPro;

namespace RAIJIN
{
	/// <summary>
	/// �^�X�t��
	/// </summary>
	public class SystemTurn : MonoBehaviour
	{

		#region ���
		private SystemControl systemControl;
		private SystemSpawn systemSpawn;
		private RecycleArea recycleArea;

		private int totalCountBullets;  //�o�g�l�u�`��
		private int totalCountEnemysLive; //�^�X��h�֪���s��

		private int totalRecycleBullets;

		public UnityEvent onTurnEnemy;

		private bool canSpawn = true;  //�ͩǭ���

		private int countEatBullet;

		private TextMeshProUGUI textFloorCount;

		private int countFloor = 1;
		private int countFloorMax = 20;
		private bool isFloorMax;

		private SystemEnd systemEnd;

		#endregion

		private void Awake()
		{
			systemControl = GameObject.Find("����").GetComponent<SystemControl>();
			systemSpawn = GameObject.Find("�ͩǨt��").GetComponent<SystemSpawn>();
			recycleArea = GameObject.Find("�^���ϰ�").GetComponent<RecycleArea>();
			textFloorCount = GameObject.Find("�h�� �Ʀr").GetComponent<TextMeshProUGUI>();
			systemEnd = FindObjectOfType<SystemEnd>();

			recycleArea.onRecyele.AddListener(RecycleBullet);
		}

		#region ��k
		private void RecycleBullet()
		{
			totalCountBullets = systemControl.howManyCanShootBullet;

			totalRecycleBullets++;
			print("�l�u�^�ӤF:" + totalRecycleBullets);

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
			if (!isFloorMax)
			{
				canSpawn = false;
				systemSpawn.SpawnRandom();
			}

			Invoke("PlayerTurn", 1f);



		}

		public void PlayerTurn()
		{
			systemControl.canShootBullet = true;
			canSpawn = true;
			totalRecycleBullets = 0;

			systemControl.howManyCanShootBullet += countEatBullet;
			countEatBullet = 0;

			if (countFloor < countFloorMax)
			{
				countFloor++;
				textFloorCount.text = countFloor.ToString();
			}

			int bulletTotal = systemControl.howManyCanShootBullet;

			systemControl.textBulletCount.text = "x" + bulletTotal;  //�^�X�}�l ��ܥثe�`��  �t�Y��

			if (countFloor == countFloorMax) isFloorMax = true;
			if (isFloorMax)
			{
				if (FindObjectsOfType<SystemMove>().Length == 0)
				{
					print("YA �q��");
					systemEnd.ShowEndTittle("���d���\"); // �o�O��Ӫ���r

				}

			}

		}



		public void EatBullet()
		{
			countEatBullet++;
		}
		#endregion





	}

}

