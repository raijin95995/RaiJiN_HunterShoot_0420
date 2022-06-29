using UnityEngine;

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
        [Tooltip("就是個箭頭"), Header("箭頭"), ]
        public GameObject arrow;
        //旋轉速度
        [Tooltip("旋轉~"), Header("旋轉速度"), Range(0, 500)]
        public float speedTurn;
        //子彈預製物
        [Tooltip("發射"), Header("子彈"), ]
        public GameObject bullet;
        //子彈數量
        [Tooltip("殘彈數2/8"), Header("子彈總數"), Range(0, 100)]
        public int howManyCanShootBullet = 15;
        #endregion


        #region 事件
        #endregion

        #region 方法
        /// <summary>
        /// 旋轉角色
        /// </summary>
        private void TurnCharacter()
        { 
        }
        /// <summary>
        /// 發射子彈
        /// </summary>
        private void ShootBullet()
        { 
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

