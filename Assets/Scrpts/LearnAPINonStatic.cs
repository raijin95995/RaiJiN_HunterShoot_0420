using UnityEngine;
/// <summary>
/// �ǲ߫D�R�AAPI
/// 
/// </summary>
public class LearnAPINonStatic : MonoBehaviour
{
    public Transform monsterTran;
    public Light isLight;
    public Transform turtleTran;

    // Start is called before the first frame update
    void Start()
    {
        print("�Ǫ��y��:" + monsterTran.position);
        print("�O���C��ƭ�:" + isLight.color);
        
        monsterTran.position += new Vector3(0,0,0.5f);  //Z�b +0.5 �ƭ�
        isLight.color = new Color(0, 0, 1);

    }

    // Update is called once per frame
    void Update()
    {
        turtleTran.Rotate(0, 5, 0);   
    }
}
