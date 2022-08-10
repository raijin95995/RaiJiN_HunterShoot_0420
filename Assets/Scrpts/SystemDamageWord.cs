using UnityEngine;
using System.Collections;
using TMPro;

namespace RAIJIN
{

    /// <summary>
    /// 傷害數字系統
    /// </summary>
    public class SystemDamageWord : MonoBehaviour
    {

        public float damage;

        [Header("紅色傷害"), SerializeField]
        private Color redColor = new Color(255,0.1f,0.1f);
        [Header("橘色傷害"), SerializeField]
        private Color orangeColor = new Color(255, 150, 50);

        private float limitUp;
        private float limitRight;
        private TextMeshProUGUI textDamage;

        private void Awake()
        {
            textDamage = GetComponentInChildren<TextMeshProUGUI>();
            textDamage.text = damage.ToString();

            if (damage >= 200) textDamage.color = redColor;
            else if (damage >= 100) textDamage.color = orangeColor;

            limitUp = Random.Range(0.2f, 0.6f);

            int r = Random.Range(0, 2);

            if (r == 0) limitRight = -0.2f;
            else if (r == 1) limitRight = 0.2f;

            StartCoroutine(MoveUp());
            StartCoroutine(MoveRight());

        }


        private IEnumerator MoveUp()
        {
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.up * limitUp;
                yield return new WaitForSeconds(0.02f);

            }

        }

        private IEnumerator MoveRight()
        {
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.right * limitRight;
                yield return new WaitForSeconds(0.02f);

            }

        }



    }

}

