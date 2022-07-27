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
        //[]可放入東西陣列的欄位
        //SF=可顯示在欄位
        [Header("怪物陣列"), SerializeField]
        private GameObject[] monsters;

        //[Header("生成位置 第二排"), SerializeField]
        //private Transform[] traSecondPlace ;

        [Header("生成位置 第二排"), SerializeField]
        private List<Transform> ListSecondPlace = new List<Transform>();

        [Header("子彈格子"), SerializeField]
        private GameObject EatBullet;


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
            int max = ListSecondPlace.Count;  //抓取清單長度
            //int max = traSecondPlace.Length;  //抓取陣列長度
            int randomCount = Random.Range(min, max);//不會抓到最大值

            print(randomCount);

            //ListSecondPlace = traSecondPlace.ToList();    用程式抓去清單

            System.Random random = new System.Random();

            ListSecondPlace = ListSecondPlace.OrderBy(x => random.Next()).ToList();

            int sub = ListSecondPlace.Count - randomCount;   //LIST用COUNT 
            print(sub);

            for (int i = 0; i < sub; i++)
            {
                ListSecondPlace.RemoveAt(0);
            }

            for (int i = 0; i < ListSecondPlace.Count; i++)
            {
                int randomIndex = Random.Range(0, monsters.Length); //給怪物排序隨機序數

                if (i == 0)
                {
                    Instantiate(EatBullet,
                     ListSecondPlace[i].position,
                     Quaternion.identity);  //生成子彈格子[隨機序數] 位置為[i](迴圈數量) 
                }
                else
                {
                    Instantiate(monsters[randomIndex],
                                        ListSecondPlace[i].position,
                                        Quaternion.identity);  //生成怪物[隨機序數] 位置為[i](迴圈數量)
                }



            }

        }

        #endregion


    }
}


