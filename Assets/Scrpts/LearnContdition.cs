using UnityEngine;

public class LearnContdition : MonoBehaviour
{
    public bool death = true ;

    private void Start()
    {
        if (true)
        {
            print("嗨嗨 我是正確");
        }
        else
        {
            print("嗨嗨 我是錯誤");
        }
    }

    private void Update()
    {
        if (death)
        {
            print("你已經死了");
        }
        else
        {
            print("你已經活了");
        }
    }

}
