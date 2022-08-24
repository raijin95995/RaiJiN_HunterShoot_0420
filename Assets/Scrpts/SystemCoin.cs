using UnityEngine;


namespace RAIJIN
{

    /// <summary>
    /// �����t��
    /// </summary>
    public class SystemCoin : MonoBehaviour
    {
        private float delayTime = 1.5f;
        private bool canFly = false;
        public float flySpeed = 5.0f;
        private Transform traCoinFlyTarget;
        private ManagerCoin managerCoin;


        private void Awake()
        {
            Physics.IgnoreLayerCollision(6, 3);
            Physics.IgnoreLayerCollision(6, 6);
            Physics.IgnoreLayerCollision(6, 7);

            traCoinFlyTarget = GameObject.Find("�����^�k��m").transform;
            managerCoin = GameObject.Find("�����޲z�t��").GetComponent<ManagerCoin>();

            Invoke("StartFly", delayTime);
        }

        private void Update()
        {
            Fly();

        }


        private void StartFly()
        {
            canFly = true;
        }


        private void Fly()
        {
            if (!canFly) return;

            Vector3 traCoin = transform.position;
            Vector3 traCoinFlyTo = traCoinFlyTarget.position;

            traCoin = Vector3.Lerp(traCoin, traCoinFlyTo, flySpeed * Time.deltaTime);

            transform.position = traCoin;

            DestroyCoin();

        }


        private void DestroyCoin()
        {
            float dis = Vector3.Distance(transform.position, traCoinFlyTarget.position);

            if (dis < 2)
            {
                managerCoin.AddCoin();
                Destroy(gameObject);
            }
        }

    }
}


