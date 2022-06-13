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
            print("總價=" + Keisan());
            Shoot("<color=red>火</color>", mana: 100);   // 指定參數   變數:參數
            Shoot("<color=lightblue>冰</color>", 30);    //如果要整串文字上色  可能要判斷  要寫長一些
            Shoot("<color=yellow>雷電</color>", 10);
            //多載
            Attack(10);
            Attack(50, "KM");

        }
        else
        {
            print("錯");
        }
    }

    #region 摺疊語法
    //請偷看內容
    #endregion

    private void Test()
    {
        //int ichi = 3;                     //測試method內重新帶入變數
        print(ichi + ni);
    }
    private void ColorText()
    {
        print("<color=yellow>我是黃色</color>");
        print("<color=#1f1e33>歌名</color>");
    }
    public int countPrice = 50;
    public int countProduct = 80;
    private int Keisan()
    {
        return countPrice * countProduct;
    }
    #region 多行寫法
    private void ShootFire()
    {
        print("火火火");
    }
    private void ShootIce()
    {
        print("冰冰冰");
    }
    #endregion

    private void Shoot(string magicType, int ballSize = 12, int mana = 10)           //小括號參數設定  放入變數類型 + 變數  上方呼叫時直接輸入變數數值
                                                                                     //有預設值得請放後面
    {
        //print("消耗" + mana + "魔力值,屬性" + magicType + "<size=" + ballSize + ">" + ballSize + "</size>" + "公分的魔力彈");
        print("<size=" + ballSize + ">" + "消耗" + mana + "魔力值,屬性" + magicType + +ballSize + "公分的魔力彈" + "</size>");
    }
    private void BallSize(int size)
    {
        print(size + "公分的法術球");
    }
    //多載 OVERLOAD 

    private void Attack(int atk)
    {
        print("戳戳");
    }
    private void Attack(int atk, string far)
    {
        print("丟丟" + atk + far);
    }

}
