using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace genaralskar
{
	public class ChangePlayerHeight : MonoBehaviour
	{

		[SerializeField]
		private Animator anims;
		
		//set trigger on animator for plane, robot, or car

		private void Start()
		{
			anims = GetComponent<Animator>();
		}

		public void ChangeState(string paramName)
		{
			anims.SetTrigger(paramName);
		}
	}
}

