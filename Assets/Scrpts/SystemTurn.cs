using UnityEngine;

namespace RAIJIN
{
    /// <summary>
    /// �^�X�t��
    /// </summary>
    public class SystemTurn : MonoBehaviour
    {
        private SystemControl systemControl;
        private SystemSpawn systemSpawn;
        private RecycleArea recycleArea;

        private void Awake()
        {
            systemControl = GameObject.Find("����").GetComponent<SystemControl>();
            systemSpawn = GameObject.Find("�ͩǨt��").GetComponent<SystemSpawn>();
            recycleArea = GameObject.Find("�^���ϰ�").GetComponent<RecycleArea>();
        }


    }

}

