using System.Collections;
using System.Collections.Generic;
using genaralskar;
using UnityEngine;

public class HealthManagerMono : MonoBehaviour
{
	public FloatConstant maxHealth;
	
	public HealthManager manager;
	
	// Use this for initialization
	private void Start()
	{
		manager.SetHealth(maxHealth.FloatValue);
	}
}
