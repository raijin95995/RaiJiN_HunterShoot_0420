using UnityEngine;

public class LearnContdition : MonoBehaviour
{
    public bool death = true ;

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
        if (death)
        {
            print("�A�w�g���F");
        }
        else
        {
            print("�A�w�g���F");
        }
    }

}
