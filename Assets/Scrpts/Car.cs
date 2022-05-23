using UnityEngine;

public class Car : MonoBehaviour
{
    [Tooltip("單位為m"), Header("車高"), Range(1, 10)]
    public int height = 1;
    [Tooltip("單位為公噸"),Header("車重"), Range(1, 10)]
    public int weight = 5;
    [Tooltip("品牌"), Header("品牌")]
    public string brand = "benz";
    [Tooltip("開天窗"), Header("是否有天窗")]
    public bool HasSkywindow = true;
    //public int My { get => height + 5; set };
    //public int MyProperty { get => height + 5; set x ; }
}