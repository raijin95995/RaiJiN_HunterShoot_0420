using UnityEngine;


namespace RAIJIN
{
	public class SystemBullet : MonoBehaviour
	{

		[Header("怪物圖層"), SerializeField]
		private LayerMask layerMonster;


		[Header("幾秒沒碰怪物就回收"), SerializeField]
		private float timeRecycle;

		[Header("回收速度"), SerializeField]
		private Vector3 v3SpeedRecycle;


		private float timer;


	}

}

