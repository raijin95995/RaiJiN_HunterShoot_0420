
using UnityEngine;
/// <summary>
/// �ǲ��R�AAPI
/// Static �R�A��
/// </summary>
public class LearnAPIStatic : MonoBehaviour
{

    /// <summary>
    /// 
    /// 1.���o
    /// ���O�W��.�R�A�ݩʦW��
    /// 2.�]�w   ��Ū����]�w  READ ONLY
    /// ���O�W��.�R�A�ݩʦW�� =  �� (�̷��ݩʳ]�w)
    /// 
    /// </summary>
    private void Start()
    {
        
        print("�H����:" + 100 * Random.value );
        print("�ڶ}:" + Mathf.Infinity );
        Cursor.visible = false; //�ƹ�����~


    }


}
