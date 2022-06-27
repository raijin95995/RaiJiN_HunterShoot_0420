using UnityEngine;

public class LearnContdition : MonoBehaviour
{
    public bool death = true;
    public int combo = 0;
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
        //if (death)
        //{
        //    print("你已經死了");
        //}
        //else
        // {
        //    print("你已經活了");
        // }
        if (combo < 100)
        {
            print("NO");
        }
        else

            if (combo >= 200)
        {
            print("GOOD");
        }
        else
                if (combo >= 100)
        {
            print("GREAT");
        }




    }

}
