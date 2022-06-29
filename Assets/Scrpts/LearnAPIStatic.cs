
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
    /// </summary>
    private void Start()
    {
        
        print("隨機值:" + 100 * Random.value );
        print("我開:" + Mathf.Infinity);
    }


}
