using UnityEngine;

//�R�W�Ŷ�  �Ŷ��W�� { ���e }
namespace RAIJIN
{
    /// <summary>
    /// �]�w����ƥ� 
    /// </summary>
    public class SystemControl : MonoBehaviour
    {
        #region ���
        //�b�Y
        [Tooltip("�N�O�ӽb�Y"), Header("�b�Y"), ]
        public GameObject arrow;
        //����t��
        [Tooltip("����~"), Header("����t��"), Range(0, 500)]
        public float speedTurn;
        //�l�u�w�s��
        [Tooltip("�o�g"), Header("�l�u"), ]
        public GameObject bullet;
        //�l�u�ƶq
        [Tooltip("�ݼu��2/8"), Header("�l�u�`��"), Range(0, 100)]
        public int howManyCanShootBullet = 15;
        #endregion
        
        
        #region �ƥ�
        #endregion
        #region ��k
        #endregion

    }
}

