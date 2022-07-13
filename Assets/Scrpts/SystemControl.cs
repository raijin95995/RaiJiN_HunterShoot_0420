using UnityEngine;

//�R�W�Ŷ�  �Ŷ��W�� { ���e }
namespace RAIJIN
{
    /// <summary>
    /// ���a����t��
    /// ���ਤ�� �o�g�u�]
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
        [Tooltip("�o�g"), Header("�o�g��m"),]
        public Transform traShootPoint;
        [Header("�����ʵe")]
        public string perAttack = "Ĳ�o����";

        public Animator anime;


        #endregion


        #region �ƥ�

        private void Update()
        {
            ShootBullet();
        }

        #endregion

        #region ��k
        /// <summary>
        /// ���ਤ��
        /// </summary>
        private void TurnCharacter()
        { 
        }
        /// <summary>
        /// �o�g�l�u
        /// </summary>
        private void ShootBullet()
        { 
            if(Input.GetKeyUp(KeyCode.Mouse0))
            {
                print("��}����");
                Instantiate(bullet,traShootPoint.position,Quaternion.identity);
            }
        }
        /// <summary>
        /// �^���l�u
        /// </summary>
        private void RecycleBullet() 
        { 
        }
        #endregion

    }
}

