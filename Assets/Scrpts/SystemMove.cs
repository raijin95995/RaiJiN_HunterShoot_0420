using UnityEngine;
using System.Collections;

namespace RAIJIN
{
    /// <summary>
    /// 移動系統
    /// </summary>
    public class SystemMove : MonoBehaviour
    {
        private SystemTurn systemTurn;

        private float moveDistance = 2;


        private void Awake()
        {
            systemTurn = GameObject.Find("回合系統").GetComponent<SystemTurn>();
            systemTurn.onTurnEnemy.AddListener(() => { StartCoroutine(Move()); });

        }


        
        private  IEnumerator Move()
        {
            //print(gameObject + "他動了");
            float moveCount = 10;
            float perDistance = moveDistance / moveCount;

            for (int i = 0; i < moveCount; i++)
            {
                transform.position -= new Vector3(0, 0, perDistance);
                yield return new WaitForSeconds(0.05f);
            }

            yield return new WaitForSeconds(1.2f);
             
            systemTurn.MoveEndSpawnEnemy();  //生成系統
        }















    }
}

