using UnityEngine;


namespace RAIJIN
{
	public class SystemBullet : MonoBehaviour
	{

		[Header("�Ǫ��ϼh"), SerializeField]
		private LayerMask layerMonster;


		[Header("�X��S�I�Ǫ��N�^��"), SerializeField]
		private float timeRecycle;

		[Header("�^���t��"), SerializeField]
		private Vector3 v3SpeedRecycle;


		private float timer;


	}

}

