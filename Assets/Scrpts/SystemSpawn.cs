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
        //[]�}�C�����
        //SF=�i��ܦb���
        [Header("�Ǫ��}�C"),SerializeField]
        private GameObject[] monsters;

        [Header("�ͦ���m �ĤG��"), SerializeField]
        private Transform[] traSecondPlace ;

        [SerializeField]
        private List<Transform> ListSecondPlace = new List<Transform>();


        #endregion

        #region �ƥ�

        private void Awake()
        {
            SpawnRandom();
        }

        #endregion



        #region ��k


        void SpawnRandom()
        {
            int min = 2;  //�̤p��
            int max = traSecondPlace.Length;  //����}�C����

            print(Random.Range(min, max));   //���|���̤j��

            //ListSecondPlace = traSecondPlace.ToList();

            System.Random random = new System.Random();

            ListSecondPlace = ListSecondPlace.OrderBy(x => random.Next()).ToList();

        }

        #endregion


    }
}


