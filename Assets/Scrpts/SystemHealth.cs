using UnityEngine;
using UnityEngine.UI;
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

        void GetHurt()
        {
            hp -= 100;

            textHp.text = hp.ToString();

            imgHp.fillAmount = hp / dataEnemy.hp;

            if (hp <= 0) Die();

        }

        void Die()
        {
            print("�A�w�g���F");

        }

    }
}

