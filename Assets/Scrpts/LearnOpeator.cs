using UnityEngine;

/// <summary>
/// �B��l
/// �ƾǹB��l
/// ����B��l
/// �޿�B��l
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
        //�ƾ�
        print("�[�[:" + (a + b));
        print("���:" + (a - b));
        print("����:" + (a * b));
        print("����:" + (a / b));
        print("�l�l:" + (a % b));
        //���
        print("�j��:" + (c > d));
        print("�p��:" + (c < d));
        print("�j�󵥩�:" + (c >= d));
        print("�p�󵥩�:" + (c <= d));
        print("����:" + (c == d));
        print("������:" + (c != d));
        //�åB
        print("TandT:" + (t && t));
        print("TandF:" + (t && f));
        print("FandT:" + (f && t));
        print("FandF:" + (f && f));
        //��
        print("TorT:" + (t || t));
        print("TorF:" + (t || f));
        print("ForT:" + (f || t));
        print("ForF:" + (f || f));

        //ex
        print("�}������G���W�L�T�ӥ��Y�άO�L�l��");

        //�A�˹B��l
        print("�A�˵��G !c>d:" + (!(c > d)));
        print("�A�˵��G !c<d:" + (!(c < d)));



    }
}
