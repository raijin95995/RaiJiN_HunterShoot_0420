using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace RAIJIN
{
    /// <summary>
    /// �Ǫ��ͦ��t��
    /// </summary>
    public class SystemSpawn : MonoBehaviour
    {

        #region ���
        //[]�i��J�F��}�C�����
        //SF=�i��ܦb���
        [Header("�Ǫ��}�C"), SerializeField]
        private GameObject[] monsters;

        //[Header("�ͦ���m �ĤG��"), SerializeField]
        //private Transform[] traSecondPlace ;

        [Header("�ͦ���m �ĤG��"), SerializeField]
        private List<Transform> ListSecondPlace = new List<Transform>();

        [Header("�l�u��l"), SerializeField]
        private GameObject EatBullet;

        [HideInInspector]
        public int totalCountEnemysLive; //�^�X��h�֪���s��

        #endregion

        #region �ƥ�

        private void Awake()
        {
            SpawnRandom();
        }

        #endregion



        #region ��k


        public void SpawnRandom()
        {
            int min = 2;  //�̤p��
            int max = ListSecondPlace.Count;  //����M�����
            //int max = traSecondPlace.Length;  //����}�C����
            int randomCount = Random.Range(min, max);//���|���̤j��

            print(randomCount);

            //ListSecondPlace = traSecondPlace.ToList();    �ε{����h�M��

            System.Random random = new System.Random();

            ListSecondPlace = ListSecondPlace.OrderBy(x => random.Next()).ToList();

            int sub = ListSecondPlace.Count - randomCount;   //LIST��COUNT 
            print(sub);

            for (int i = 0; i < sub; i++)
            {
                ListSecondPlace.RemoveAt(0);
            }

            for (int i = 0; i < ListSecondPlace.Count; i++)
            {
                int randomIndex = Random.Range(0, monsters.Length); //���Ǫ��Ƨ��H���Ǽ�

                if (i == 0)
                {
                    Instantiate(EatBullet,
                     ListSecondPlace[i].position,
                     Quaternion.identity);  //�ͦ��l�u��l[�H���Ǽ�] ��m��[i](�j��ƶq) 
                }
                else
                {
                    Instantiate(monsters[randomIndex],
                                        ListSecondPlace[i].position,
                                        Quaternion.identity);  //�ͦ��Ǫ�[�H���Ǽ�] ��m��[i](�j��ƶq)
                }


                totalCountEnemysLive++;
                print("�ͦ��F�X��:" + totalCountEnemysLive);
            }

        }

        #endregion


    }
}


