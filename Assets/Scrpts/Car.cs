using UnityEngine;

public class Car : MonoBehaviour
{
    [Tooltip("��쬰m"), Header("����"), Range(1, 10)]
    public int height = 1;
    [Tooltip("��쬰����"),Header("����"), Range(1, 10)]
    public int weight = 5;
    [Tooltip("�~�P"), Header("�~�P")]
    public string brand = "benz";
    [Tooltip("�}�ѵ�"), Header("�O�_���ѵ�")]
    public bool HasSkywindow = true;
    //public int My { get => height + 5; set };
    //public int MyProperty { get => height + 5; set x ; }
}