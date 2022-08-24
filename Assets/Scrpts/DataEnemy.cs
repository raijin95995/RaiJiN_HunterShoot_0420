using UnityEngine;

namespace RAIJIN
{
    /// <summary>
    /// �}���ƪ���
    /// </summary>
    [CreateAssetMenu(menuName = "RAIJIN/Data Enemy", fileName = "Data Enemy")]
    public class DataEnemy : ScriptableObject
    {
        [Header("��q"), Range(0, 10000)]
        public float hp;
        [Header("�ˮ`"), Range(0, 1000)]
        public float damage;
        [Header("�����w�s��")]
        public GameObject coin;
        [Header("�]�w�����ƶq�d��")]
        public Vector2Int v2CoinRange;



    }
}

