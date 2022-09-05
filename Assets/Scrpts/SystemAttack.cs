using UnityEngine;


namespace RAIJIN
{
    public class SystemAttack : MonoBehaviour
    {

        [Header("§ðÀ»¸ê®Æ"), SerializeField]
        private DataAttack dataAttack;


        public float valueAttck;

        private void Awake()
        {
            valueAttck = dataAttack.attack + Random.Range(-dataAttack.attackFloat, dataAttack.attackFloat);
            valueAttck = Mathf.Floor(valueAttck);

        }



    }

}

