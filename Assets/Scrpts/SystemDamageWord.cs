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

        [Header("間隔"), SerializeField]
        private float waitTime = 0.025f; 

        public float damage;

        [Header("紅色傷害"), SerializeField]
        private Color redColor = new Color(255,0.1f,0.1f);
        [Header("橘色傷害"), SerializeField]
        private Color orangeColor = new Color(255, 150, 50);

        private float limitUp;
        private float limitRight;
        private TextMeshProUGUI textDamage;

        private void Start()
        {
            textDamage = GetComponentInChildren<TextMeshProUGUI>();
            textDamage.text = damage.ToString();

            if (damage >= 200) textDamage.color = redColor;
            else if (damage >= 100) textDamage.color = orangeColor;

            limitUp = Random.Range(0.4f, 0.6f);

            int r = Random.Range(0, 2);

            if (r == 0) limitRight = -0.2f;
            else if (r == 1) limitRight = 0.2f;

            StartCoroutine(MoveUp());
            StartCoroutine(MoveRight());
            StartCoroutine(ScaleEffect());
            //StartCoroutine(ColorEffect());

        }


        private IEnumerator MoveUp()
        {
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.up * limitUp;
                yield return new WaitForSeconds(waitTime);

            }

            for (int i = 0; i < 3; i++)
            {
                transform.position -= transform.up * limitUp;
                yield return new WaitForSeconds(waitTime);
            }

            for (int i = 0; i < 10; i++)
            {
                textDamage.color -= new Color(0,0,0,0.1f);
                yield return new WaitForSeconds(waitTime);
            }

        }

        private IEnumerator MoveRight()
        {
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.right * limitRight;
                yield return new WaitForSeconds(waitTime);

            }

        }

        private IEnumerator ScaleEffect()
        {
            for (int i = 0; i < 4; i++)
            {
                transform.localScale += Vector3.one * 0.001f;
                yield return new WaitForSeconds(waitTime);

            }
            for (int i = 0; i < 4; i++)
            {
                transform.localScale -= Vector3.one * 0.001f;
                yield return new WaitForSeconds(waitTime);

            }
        }

        private IEnumerator ColorEffect()
        {

            if (damage >= 200)
            {
                for (int i = 0; i < 20; i++)
                {
                    textDamage.color -= new Color(10, 0, 0, 0.05f);

                    yield return new WaitForSeconds(waitTime);

                }
            }
            else if (damage >= 100 )
            {

                for (int i = 0; i < 20; i++)
                {
                    textDamage.color -= new Color(10, 10, 10, 0.05f);

                    yield return new WaitForSeconds(0.005f);

                }
            }
           
        }

    }

}

