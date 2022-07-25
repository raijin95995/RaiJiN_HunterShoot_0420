using UnityEngine;
using System.Collections;
using TMPro;

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
        [Header("�u�]�o�g�t��"), Range(0, 5000)]
        public float speedBullet = 1000;
        [Header("�l�u�o�g���j"), Range(0, 2)]
        public float intervalBullet = 0.5f;

        private bool canShootBullet = true; 

        public TextMeshProUGUI textBulletCount; 

        private Animator anime;
        /// <summary>
        /// ��������m��v��
        /// </summary>
        private Camera cameraMouse;
        /// <summary>
        /// �ഫ�y�й���
        /// </summary>
        private Transform traMouse;





        #endregion


        #region �ƥ�

        private void Awake()
        {
            anime = GetComponent<Animator>();

            textBulletCount.text = "x" + howManyCanShootBullet;

            cameraMouse = GameObject.Find("��������m��v��").GetComponent<Camera>();
            traMouse = GameObject.Find("�ഫ�y�й���").GetComponent<Transform>();
        }


        private void Update()
        {
            ShootBullet();
            TurnCharacter();
        }

        #endregion

        #region ��k
        /// <summary>
        /// ���ਤ��
        /// </summary>
        private void TurnCharacter()
        {
            if (!canShootBullet) return ;
            
            Vector3 posMouse = Input.mousePosition;
            
            //print("�ƹ���m:" + posMouse);
            posMouse.z = 25;

            Vector3 pos = cameraMouse.ScreenToWorldPoint(posMouse);

            pos.y = 0.5f;

            traMouse.position = pos;

            transform.LookAt(traMouse);

        }
        /// <summary>
        /// �o�g�l�u
        /// </summary>
        private void ShootBullet()
        {
            if (!canShootBullet) return;
            // ���U �ƹ����� ��� �b�Y
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                arrow.SetActive(true);
            }
            // ��} �ƹ����� ���ýb�Y �ͦ��õo�g�u�]
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

                // Object ���O�i�ٲ����g
                // �����z�L Object �����W�٨ϥ�
                // �ͦ�(�u�])�F
                // Quaternion.identity �s�ר�
                GameObject tempBullet = Instantiate(bullet, traShootPoint.position, Quaternion.identity);
                // �Ȧs�u�] ���o���餸�� �K�[���O (����.�e�� * �t��)
                // transform.forward ���⪺�e��
                tempBullet.GetComponent<Rigidbody>().AddForce(transform.forward * speedBullet);
                total--;

                if (total > 0) textBulletCount.text = "x" + total;
                else if (total == 0) textBulletCount.text = "";

                yield return new WaitForSeconds(intervalBullet);
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

