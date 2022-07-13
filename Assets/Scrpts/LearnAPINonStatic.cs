using UnityEngine;
/// <summary>
/// 學習非靜態API
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
        print("怪物座標:" + monsterTran.position);
        print("燈光顏色數值:" + isLight.color);
        
        monsterTran.position += new Vector3(0,0,0.5f);  //Z軸 +0.5 數值
        isLight.color = new Color(0, 0, 1);

    }

    // Update is called once per frame
    void Update()
    {
        turtleTran.Rotate(0, 5, 0);   
    }
}
