using UnityEngine;

namespace RAIJIN
{
    /// <summary>
    /// �}���ƪ���
    /// </summary>
    [CreateAssetMenu(menuName = "RAIJIN/Data Attack", fileName = "Data Attack")]
    public class DataAttack : ScriptableObject
    {

        [Header("�����O"), Range(0, 10000)]
        public float attack;
        [Header("�����O�B�� �W���"), Range(0, 100)]
        public float attackFloat;

    }
}

