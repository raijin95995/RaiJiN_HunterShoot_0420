using UnityEngine;
using System.Collections;
using TMPro;

//命名空間  空間名稱 { 內容 }
namespace RAIJIN
{
    /// <summary>
    /// 玩家控制系統
    /// 旋轉角色 發射彈珠
    /// </summary>
    public class SystemControl : MonoBehaviour
    {
        #region 資料
        //箭頭
        [Tooltip("就是個箭頭"), Header("箭頭"),]
        public GameObject arrow;
        //旋轉速度
        [Tooltip("旋轉~"), Header("旋轉速度"), Range(0, 500)]
        public float speedTurn;
        //子彈預製物
        [Tooltip("發射"), Header("子彈"),]
        public GameObject bullet;
        //子彈數量
        [Tooltip("殘彈數2/8"), Header("子彈總數"), Range(0, 100)]
        public int howManyCanShootBullet = 15;
        [Tooltip("發射"), Header("發射位置"),]
        public Transform traShootPoint;
        [Header("攻擊動畫")]
        public string perAttack = "觸發攻擊";
        [Header("彈珠發射速度"), Range(0, 5000)]
        public float speedBullet = 1000;
        [Header("子彈發射間隔"), Range(0, 2)]
        public float intervalBullet = 0.5f;

        private bool canShootBullet = true;

        public TextMeshProUGUI textBulletCount;

        private Animator anime;
        /// <summary>
        /// 控制旋轉位置攝影機
        /// </summary>
        private Camera cameraMouse;
        /// <summary>
        /// 轉換座標實體
        /// </summary>
        private Transform traMouse;





        #endregion


        #region 事件

        private void Awake()
        {
            anime = GetComponent<Animator>();

            textBulletCount.text = "x" + howManyCanShootBullet;

            cameraMouse = GameObject.Find("控制旋轉位置攝影機").GetComponent<Camera>();
            traMouse = GameObject.Find("轉換座標實體").GetComponent<Transform>();

            Physics.IgnoreLayerCollision(3, 3);

        }


        private void Update()
        {
            ShootBullet();
            TurnCharacter();
        }

        #endregion

        #region 方法
        /// <summary>
        /// 旋轉角色
        /// </summary>
        private void TurnCharacter()
        {
            if (!canShootBullet) return;

            Vector3 posMouse = Input.mousePosition;

            //print("滑鼠位置:" + posMouse);
            posMouse.z = 25;

            Vector3 pos = cameraMouse.ScreenToWorldPoint(posMouse);

            pos.y = 0.5f;

            traMouse.position = pos;

            transform.LookAt(traMouse);

        }
        /// <summary>
        /// 發射子彈
        /// </summary>
        private void ShootBullet()
        {
            if (!canShootBullet) return;
            // 按下 滑鼠左鍵 顯示 箭頭
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                arrow.SetActive(true);
            }
            // 放開 滑鼠左鍵 隱藏箭頭 生成並發射彈珠
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {

                canShootBullet = false;
                arrow.SetActive(false);
                StartCoroutine(SpawnBullet());
            }
        }

        private IEnumerator SpawnBullet()
        {
            int total = howManyCanShootBullet;

            for (int i = 0; i < howManyCanShootBullet; i++)
            {
                anime.SetTrigger(perAttack);

                // Object 類別可省略不寫
                // 直接透過 Object 成員名稱使用
                // 生成(彈珠)；
                // Quaternion.identity 零度角
                GameObject tempBullet = Instantiate(bullet, traShootPoint.position, Quaternion.identity);
                // 暫存彈珠 取得剛體元件 添加推力 (角色.前方 * 速度)
                // transform.forward 角色的前方
                tempBullet.GetComponent<Rigidbody>().AddForce(transform.forward * speedBullet);
                total--;  //顯示減少子彈數字

                if (total > 0) textBulletCount.text = "x" + total;
                else if (total == 0) textBulletCount.text = "";

                yield return new WaitForSeconds(intervalBullet);
            }
        }

        /// <summary>
        /// 回收子彈
        /// </summary>
        private void RecycleBullet()
        {
        }
        #endregion

    }
}

