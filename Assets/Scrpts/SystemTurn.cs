using UnityEngine;

namespace RAIJIN
{
    /// <summary>
    /// 回合系統
    /// </summary>
    public class SystemTurn : MonoBehaviour
    {
        private SystemControl systemControl;
        private SystemSpawn systemSpawn;
        private RecycleArea recycleArea;

        private void Awake()
        {
            systemControl = GameObject.Find("狗狗").GetComponent<SystemControl>();
            systemSpawn = GameObject.Find("生怪系統").GetComponent<SystemSpawn>();
            recycleArea = GameObject.Find("回收區域").GetComponent<RecycleArea>();
        }


    }

}

