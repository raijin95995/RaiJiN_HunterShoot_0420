using UnityEngine;

public class LearnContdition : MonoBehaviour
{
    public bool death = true;
    public int combo = 0;
    private void Start()
    {
        if (true)
        {
            print("�ٶ� �ڬO���T");
        }
        else
        {
            print("�ٶ� �ڬO���~");
        }
    }

    private void Update()
    {
        //if (death)
        //{
        //    print("�A�w�g���F");
        //}
        //else
        // {
        //    print("�A�w�g���F");
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
