using UnityEngine;
using TMPro;

namespace RAIJIN
{
    public class ManagerCoin : MonoBehaviour
    {
        private TextMeshProUGUI textCoin;

        private int totalCoin;


        private void Awake()
        {
            textCoin = GameObject.Find("���� �Ʀr").GetComponent<TextMeshProUGUI>();


        }



        public void AddCoin()
        {
            totalCoin++;
            textCoin.text = totalCoin.ToString();

        }



    }
}


