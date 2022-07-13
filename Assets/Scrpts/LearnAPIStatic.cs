using UnityEngine;
/// <summary>
/// 學習靜態API
/// Static 靜態的
/// </summary>
public class LearnAPIStatic : MonoBehaviour
{

    /// <summary>
    /// 
    /// 1.取得
    /// 類別名稱.靜態屬性名稱
    /// 2.設定   唯讀不能設定  READ ONLY
    /// 類別名稱.靜態屬性名稱 =  值 (依照屬性設定)
    /// 
    /// </summary>
    private void Start()
    {
        
        print("隨機值:" + 100 * Random.value );
        print("我開:" + Mathf.Infinity );
        Cursor.visible = false; //滑鼠不見~

        float r = Random.Range(1.0f, 2.0f);
        print("數值:" + r * 10);


    }


}
