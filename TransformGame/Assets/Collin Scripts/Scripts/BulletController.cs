using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace genaralskar
{
	[RequireComponent(typeof(Rigidbody))]
	public class BulletController : MonoBehaviour
	{
		
		private Rigidbody rb;

		public float bulletSpeed = 5;
		
		// Use this for initialization
		private void Start ()
		{
			rb = GetComponent<Rigidbody>();
			rb.velocity = transform.forward * bulletSpeed;
		}
		
	}
}

