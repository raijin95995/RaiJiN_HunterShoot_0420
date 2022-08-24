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

        private string getHit = "����";


        private float hp;



        private SystemSpawn systemSpawn;

        private void Awake()
        {
            
            hp = dataEnemy.hp;
            textHp.text = hp.ToString();

            systemSpawn = GameObject.Find("�ͩǨt��").GetComponent<SystemSpawn>();
            
        }

        private void OnCollisionEnter(Collision collision)
        {

            GetHurt();
        }

        private  void GetHurt()
        {
            float getDamage = 50;
            hp -= getDamage;

            textHp.text = hp.ToString();

            imgHp.fillAmount = hp / dataEnemy.hp;

            monsterAnime.SetTrigger(getHit);

            Vector3 pos = transform.position + Vector3.up;

            SystemDamageWord tempDamage = Instantiate(goDamage, pos, Quaternion.Euler(45, 0, 0)).GetComponent<SystemDamageWord>();
            
            tempDamage.damage = getDamage;

            if (hp <= 0) Die();



        }

        void Die()
        {
            //print("�A�w�g���F");
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


    }
}

