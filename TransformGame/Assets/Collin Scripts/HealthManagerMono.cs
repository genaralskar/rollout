﻿using System.Collections;
using System.Collections.Generic;
using genaralskar;
using UnityEngine;

public class HealthManagerMono : MonoBehaviour
{
	
	public HealthManager manager;
	
	// Use this for initialization
	private void OnEnable()
	{
		manager.SetHealth(manager.maxHealth.FloatValue);
	}
}
