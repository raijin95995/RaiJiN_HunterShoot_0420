using UnityEngine;

public class LearnContdition : MonoBehaviour
{
    public bool death = true;
    public int combo = 0;
    public int AA = 5;

    public enum HpPercent
    {
        a100, b50, A10
    }

    public HpPercent hpPercent;


    private void Start()
    {
        if (true)
        {
            print("嗨嗨 我是正確");
        }
        else
        {
            //print("嗨嗨 我是錯誤");
        }
    }

    private void Update()
    {
        #region IF
        if (death)
        {
            print("你已經死了");
        }
        else
        {
            print("你已經活了");
        }
        if (combo < 100)
        {
            print("NO");
        }
        else

            if (combo >= 200)
        {
            print("GOOD");
        }
        else
                if (combo >= 100)
        {
            print("GREAT");
        }

        #endregion
        #region SWITCH
        switch (AA)
        {
            case 5:
                print("我有" + AA + "個蘋果");
                break;
            case 10:
                print("我有" + AA + "個蘋果");
                break;

            default:
                break;

        }

        switch (hpPercent)
        {
            case HpPercent.a100:
                print("熱血滿滿");
                break;
            case HpPercent.b50:
                print("還有一半血量");
                break;
            case HpPercent.A10:
                print("快乾了");
                break;
            default:
                break;
        }

        #endregion
    }

}
