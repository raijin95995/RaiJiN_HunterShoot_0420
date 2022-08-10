using UnityEngine;
using UnityEngine.Events;

namespace RAIJIN
{ 
    /// <summary>
    /// 回收區域
    /// </summary>
    public class RecycleArea : MonoBehaviour
    {

        public UnityEvent onRecyele;

        private void OnTriggerEnter(Collider other)
        {

            if(other.name.Contains("子彈"))
            {
                print("我被穿過了~~~");
            }
            


        }


    }

}

