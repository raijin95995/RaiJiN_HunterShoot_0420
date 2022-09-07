using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

namespace RAIJIN
{

	/// <summary>
	/// 控制血量
	/// </summary>
	public class SystemHealth : MonoBehaviour
	{

		[Header("畫布傷害物件"), SerializeField]
		private GameObject goDamage;
		[Header("血量圖片"), SerializeField]
		private Image imgHp;
		[Header("血量文字"), SerializeField]
		private TextMeshProUGUI textHp;
		[Header("怪物資料"), SerializeField]
		private DataEnemy dataEnemy;
		[Header("怪物動畫"), SerializeField]
		private Animator monsterAnime;

		[Header("碰撞的物件"), SerializeField]
		private string nameHurtObject;


		[Header("玩家接受傷害區域")]
		[SerializeField] private Vector3 v3DamageSize;
		[SerializeField] private Vector3 v3DamagePosition;

		[Header("怪物圖層"), SerializeField]
		private LayerMask layerDamage;



		private string getHit = "受傷";


		private float hp;



		private SystemSpawn systemSpawn;

		private void Awake()
		{

			hp = dataEnemy.hp;
			textHp.text = hp.ToString();

			systemSpawn = GameObject.Find("生怪系統").GetComponent<SystemSpawn>();

		}

		private void Update()
		{
			CheckObjectINDamageArea();
		}



		private void OnCollisionEnter(Collision collision)
		{

			if (collision.gameObject.name.Contains(nameHurtObject)) GetHurt(collision.gameObject.GetComponent<SystemAttack>().valueAttck);

		}

		private void GetHurt(float damage)
		{
			
			hp -= damage;

			textHp.text = hp.ToString();

			imgHp.fillAmount = hp / dataEnemy.hp;

			monsterAnime.SetTrigger(getHit);

			Vector3 pos = transform.position + Vector3.up;

			SystemDamageWord tempDamage = Instantiate(goDamage, pos, Quaternion.Euler(45, 0, 0)).GetComponent<SystemDamageWord>();

			tempDamage.damage = damage;

			if (hp <= 0) Die();



		}

		void Die()
		{
			//print("你已經死了");
			Destroy(gameObject);
			systemSpawn.totalCountEnemysLive--;
			DropCoin();
		}

		void DropCoin()
		{
			int ran = Random.Range(dataEnemy.v2CoinRange.x, dataEnemy.v2CoinRange.y);

			for (int i = 0; i < ran; i++)
			{
				float ranX = Random.Range(-1, 1);
				float ranZ = Random.Range(-1, 1);

				Instantiate(
								dataEnemy.coin,
								transform.position + new Vector3(ranX, 2.7f, ranZ),
								Quaternion.identity
								);

			}

		}

		private void OnDrawGizmos()
		{
			Gizmos.color = new Color(0.2f, 1, 0.2f, 0.5f);
			Gizmos.DrawCube(v3DamagePosition, v3DamageSize);
		}


		private void CheckObjectINDamageArea()
		{
			Collider[] hits = Physics.OverlapBox(v3DamagePosition, v3DamageSize / 2, Quaternion.identity, layerDamage);

			if (hits.Length > 0)
			{


				print("不要過來啊RRR:" + hits[0]);

				GetHurt(hits[0].GetComponent<SystemAttack>().valueAttck);
				Destroy(hits[0].gameObject);

			}
		}

	}
}

