using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    //��k�y�k
    int ichi = 1;
    int ni = 2;
    private void Start()
    {

        ColorText();
        print("1+2=�h��");
        if (ni > ichi)
        {
            Test();
        }
        else
        {
            print("��");
        }
    }

    private void Test()
    {
        //int ichi = 3; //����method�����s�a�J�ܼ�
        print(ichi + ni);
    }
    private void ColorText()
    {
        print("<color=yellow>�ڬO����</color>");
        print("<color=#1f1e33>�q�W</color>");
    }
}
