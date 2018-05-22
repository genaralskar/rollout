using System.Collections;
using System.Collections.Generic;
using genaralskar;
using UnityEngine;

public class EnemyHealthManagerMono : HealthManagerMono
{

	[SerializeField] private Hurtbox[] hurtboxes;
	[SerializeField] private UIHealth healthUI;
	
	// Use this for initialization
	void Awake ()
	{
		FloatConstant tempMaxHealth = manager.maxHealth;
		
		FloatConstant tempCurrentHealth = ScriptableObject.CreateInstance<FloatConstant>();
		tempCurrentHealth.FloatValue = manager.currentHealth.FloatValue;
		
		manager = ScriptableObject.CreateInstance<HealthManager>();
		manager.maxHealth = tempMaxHealth;
		manager.currentHealth = tempCurrentHealth;

		healthUI.healthManager = manager;
		
		manager.healthAtZero += HealthAtZeroHandler;
		manager.healthUpdate += HealthUpdateHandler;
		
		foreach (var hurtbox in hurtboxes)
		{
			hurtbox.healthManager = manager;
		}
	}

	private void HealthUpdateHandler(float currentHealth, float normalizedHealth)
	{
	}

	private void HealthAtZeroHandler()
	{
		gameObject.SetActive(false);
	}

	
}
