using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace RAIJIN
{
    /// <summary>
    /// 怪物生成系統
    /// </summary>
    public class SystemSpawn : MonoBehaviour
    {

        #region 資料
        //[]陣列的欄位
        //SF=可顯示在欄位
        [Header("怪物陣列"),SerializeField]
        private GameObject[] monsters;

        [Header("生成位置 第二排"), SerializeField]
        private Transform[] traSecondPlace ;

        [SerializeField]
        private List<Transform> ListSecondPlace = new List<Transform>();


        #endregion

        #region 事件

        private void Awake()
        {
            SpawnRandom();
        }

        #endregion



        #region 方法


        void SpawnRandom()
        {
            int min = 2;  //最小值
            int max = traSecondPlace.Length;  //抓取陣列長度

            print(Random.Range(min, max));   //不會抓到最大值

            //ListSecondPlace = traSecondPlace.ToList();

            System.Random random = new System.Random();

            ListSecondPlace = ListSecondPlace.OrderBy(x => random.Next()).ToList();

        }

        #endregion


    }
}


