
using UnityEngine;

namespace RAIJIN
{
    /// <summary>
    /// 腳本化物件
    /// </summary>
    [CreateAssetMenu(menuName = "RAIJIN/Data Enemy", fileName = "Data Enemy")]
    public class DataEnemy : ScriptableObject
    {
        [Header("血量"), Range(0, 10000)]
        public float hp;
        [Header("傷害"), Range(0, 1000)]
        public float damage;

    }
}

