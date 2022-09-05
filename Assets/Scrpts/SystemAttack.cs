using UnityEngine;


namespace RAIJIN
{
    public class SystemAttack : MonoBehaviour
    {

        [Header("�������"), SerializeField]
        private DataAttack dataAttack;

        [HideInInspector]
        public float valueAttck;

        private void Awake()
        {
            valueAttck = dataAttack.attack + Random.Range(-dataAttack.attackFloat, dataAttack.attackFloat);
            valueAttck = Mathf.Floor(valueAttck);

        }



    }

}

