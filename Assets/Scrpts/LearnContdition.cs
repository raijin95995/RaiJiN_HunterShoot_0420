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
            print("�ٶ� �ڬO���T");
        }
        else
        {
            print("�ٶ� �ڬO���~");
        }
    }

    private void Update()
    {
        #region IF
        if (death)
        {
            print("�A�w�g���F");
        }
        else
        {
            print("�A�w�g���F");
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
                print("�ڦ�" + AA + "��ī�G");
                break;
            case 10:
                print("�ڦ�" + AA + "��ī�G");
                break;

            default:
                break;

        }

        switch (hpPercent)
        {
            case HpPercent.a100:
                print("���庡��");
                break;
            case HpPercent.b50:
                print("�٦��@�b��q");
                break;
            case HpPercent.A10:
                print("�ְ��F");
                break;
            default:
                break;
        }

        #endregion
    }

}
