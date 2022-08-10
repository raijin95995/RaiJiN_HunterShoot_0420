using UnityEngine;
using UnityEngine.UI;
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

        private string getHit = "受傷";


        private float hp;

        private void Awake()
        {
            hp = dataEnemy.hp;
            textHp.text = hp.ToString();

            //monsterAnime = GetComponent<Animator>();
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

            monsterAnime.SetTrigger(getHit);

            if (hp <= 0) Die();



        }

        void Die()
        {
            print("你已經死了");

        }

    }
}

