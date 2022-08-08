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


        private void OnCollisionEnter(Collision collision)
        {
            

        }

    }
}

