using UnityEngine;

/// <summary>
/// 運算子
/// 數學運算子
/// 比較運算子
/// 邏輯運算子
/// </summary>

public class LearnOpeator : MonoBehaviour
{
    public float a = 10;
    public float b = 3;
    public int c = 100;
    public int d = 10;
    public bool t = true;
    public bool f = false;

    private void Start()
    {
        //數學
        print("加加:" + (a + b));
        print("減減:" + (a - b));
        print("乘乘:" + (a * b));
        print("除除:" + (a / b));
        print("餘餘:" + (a % b));
        //比較
        print("大於:" + (c > d));
        print("小於:" + (c < d));
        print("大於等於:" + (c >= d));
        print("小於等於:" + (c <= d));
        print("等於:" + (c == d));
        print("不等於:" + (c != d));
        //並且
        print("TandT:" + (t && t));
        print("TandF:" + (t && f));
        print("FandT:" + (f && t));
        print("FandF:" + (f && f));
        //或
        print("TorT:" + (t || t));
        print("TorF:" + (t || f));
        print("ForT:" + (f || t));
        print("ForF:" + (f || f));

        //ex
        print("破關條件：有超過三個石頭或是無損血");

        //顛倒運算子
        print("顛倒結果 !c>d:" + (!(c > d)));
        print("顛倒結果 !c<d:" + (!(c < d)));



    }
}
