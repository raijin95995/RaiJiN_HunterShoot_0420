using UnityEngine;


namespace RAIJIN
{ 
    /// <summary>
    /// 回收區域
    /// </summary>
    public class RecycleArea : MonoBehaviour
    {

        private void OnTriggerEnter(Collider other)
        {
            print("我被穿過了~~~");


        }


    }

}

