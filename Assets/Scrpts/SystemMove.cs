using UnityEngine;
using System.Collections;

namespace RAIJIN
{
    /// <summary>
    /// ���ʨt��
    /// </summary>
    public class SystemMove : MonoBehaviour
    {
        private SystemTurn systemTurn;

        private float moveDistance = 2;


        private void Awake()
        {
            systemTurn = GameObject.Find("�^�X�t��").GetComponent<SystemTurn>();
            systemTurn.onTurnEnemy.AddListener(() => { StartCoroutine(Move()); });

        }


        
        private  IEnumerator Move()
        {
            //print(gameObject + "�L�ʤF");
            float moveCount = 10;
            float perDistance = moveDistance / moveCount;

            for (int i = 0; i < moveCount; i++)
            {
                transform.position -= new Vector3(0, 0, perDistance);
                yield return new WaitForSeconds(0.05f);
            }

            yield return new WaitForSeconds(1.2f);
             
            systemTurn.MoveEndSpawnEnemy();  //�ͦ��t��
        }















    }
}

