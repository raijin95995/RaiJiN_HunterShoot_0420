using UnityEngine;
using UnityEngine.Events;

namespace RAIJIN
{ 
    /// <summary>
    /// �^���ϰ�
    /// </summary>
    public class RecycleArea : MonoBehaviour
    {

        public UnityEvent onRecyele;

        private void OnTriggerEnter(Collider other)
        {

            if(other.name.Contains("�l�u"))
            {
                //print("�ڳQ��L�F~~~");
                onRecyele.Invoke();
            }
            


        }


    }

}

