using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

namespace RAIJIN
{

	/// <summary>
	/// �����q
	/// </summary>
	public class SystemHealth : MonoBehaviour
	{

		[Header("�e���ˮ`����"), SerializeField]
		private GameObject goDamage;
		[Header("��q�Ϥ�"), SerializeField]
		private Image imgHp;
		[Header("��q��r"), SerializeField]
		private TextMeshProUGUI textHp;
		[Header("�Ǫ����"), SerializeField]
		private DataEnemy dataEnemy;
		[Header("�Ǫ��ʵe"), SerializeField]
		private Animator monsterAnime;

		[Header("�I��������"), SerializeField]
		private string nameHurtObject;


		[Header("���a�����ˮ`�ϰ�")]
		[SerializeField] private Vector3 v3DamageSize;
		[SerializeField] private Vector3 v3DamagePosition;

		[Header("�Ǫ��ϼh"), SerializeField]
		private LayerMask layerDamage;



		private string getHit = "����";


		private float hp;

		[Header("�O�_�����a"), SerializeField]
		private bool isPlayer;

		private SystemSpawn systemSpawn;

		private SystemEnd systemEnd;


		private void Awake()
		{

			hp = dataEnemy.hp;
			textHp.text = hp.ToString();

			systemSpawn = GameObject.Find("�ͩǨt��").GetComponent<SystemSpawn>();

			systemEnd = FindObjectOfType<SystemEnd>();
		}

		private void Update()
		{
			CheckObjectINDamageArea();
		}



		private void OnCollisionEnter(Collision collision)
		{

			if (collision.gameObject.name.Contains(nameHurtObject)) GetHurt(collision.gameObject.GetComponent<SystemAttack>().valueAttck);

		}


		[SerializeField, Header("���˭���")]
		private AudioClip soundHurt;
		[SerializeField, Header("���`����")]
		private AudioClip soundDie;



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

			SystemSound.instance.PlaySound(soundHurt, new Vector2(0.7f, 1.5f));

		}

		void Die()
		{

			SystemSound.instance.PlaySound(soundDie, new Vector2(0.7f, 1.5f));

			if (isPlayer) systemEnd.ShowEndTittle("�A�w�g���F");  //���a���`��r
			else
			{
				
				//print("�A�w�g���F");
				Destroy(gameObject);
				systemSpawn.totalCountEnemysLive--;
				DropCoin();

			}

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


				print("���n�L�Ӱ�RRR:" + hits[0]);

				GetHurt(hits[0].GetComponent<SystemAttack>().valueAttck);
				Destroy(hits[0].gameObject);

			}
		}

	}
}

