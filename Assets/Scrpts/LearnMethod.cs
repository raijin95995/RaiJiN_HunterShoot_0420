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
            print("�`��=" + Keisan());
            Shoot("<color=red>��</color>", mana: 100);   // ���w�Ѽ�   �ܼ�:�Ѽ�
            Shoot("<color=lightblue>�B</color>", 30);    //�p�G�n����r�W��  �i��n�P�_  �n�g���@��
            Shoot("<color=yellow>�p�q</color>", 10);
            //�h��
            Attack(10);
            Attack(50, "KM");

        }
        else
        {
            print("��");
        }
    }

    #region �P�|�y�k
    //�а��ݤ��e
    #endregion

    private void Test()
    {
        //int ichi = 3;                     //����method�����s�a�J�ܼ�
        print(ichi + ni);
    }
    private void ColorText()
    {
        print("<color=yellow>�ڬO����</color>");
        print("<color=#1f1e33>�q�W</color>");
    }
    public int countPrice = 50;
    public int countProduct = 80;
    private int Keisan()
    {
        return countPrice * countProduct;
    }
    #region �h��g�k
    private void ShootFire()
    {
        print("������");
    }
    private void ShootIce()
    {
        print("�B�B�B");
    }
    #endregion

    private void Shoot(string magicType, int ballSize = 12, int mana = 10)           //�p�A���ѼƳ]�w  ��J�ܼ����� + �ܼ�  �W��I�s�ɪ�����J�ܼƼƭ�
                                                                                     //���w�]�ȱo�Щ�᭱
    {
        //print("����" + mana + "�]�O��,�ݩ�" + magicType + "<size=" + ballSize + ">" + ballSize + "</size>" + "�������]�O�u");
        print("<size=" + ballSize + ">" + "����" + mana + "�]�O��,�ݩ�" + magicType + +ballSize + "�������]�O�u" + "</size>");
    }
    private void BallSize(int size)
    {
        print(size + "�������k�N�y");
    }
    //�h�� OVERLOAD 

    private void Attack(int atk)
    {
        print("�W�W");
    }
    private void Attack(int atk, string far)
    {
        print("���" + atk + far);
    }

}
