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

        private void Awake()
        {
            
            hp = dataEnemy.hp;
            textHp.text = hp.ToString();

            
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
            print("�A�w�g���F");

        }

    }
}

