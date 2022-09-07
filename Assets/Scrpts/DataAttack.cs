using UnityEngine;

namespace RAIJIN
{
    /// <summary>
    /// 腳本化物件
    /// </summary>
    [CreateAssetMenu(menuName = "RAIJIN/Data Attack", fileName = "Data Attack")]
    public class DataAttack : ScriptableObject
    {

        [Header("攻擊力"), Range(0, 10000)]
        public float attack;
        [Header("攻擊力浮動 增減值"), Range(0, 100)]
        public float attackFloat;

    }
}

