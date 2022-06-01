using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    //方法語法
    int ichi = 1;
    int ni = 2;
    private void Start()
    {

        ColorText();
        print("1+2=多少");
        if (ni > ichi)
        {
            Test();
        }
        else
        {
            print("錯");
        }
    }

    private void Test()
    {
        //int ichi = 3; //測試method內重新帶入變數
        print(ichi + ni);
    }
    private void ColorText()
    {
        print("<color=yellow>我是黃色</color>");
        print("<color=#1f1e33>歌名</color>");
    }
}
