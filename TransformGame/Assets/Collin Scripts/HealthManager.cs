using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace genaralskar
{
	[CreateAssetMenu(menuName = "genaralskar/Health Manager")]
	public class HealthManager : ScriptableObject
	{
		
		//maybe change health to ints instead of floats?
	
		public FloatConstant maxHealth;
		public FloatConstant currentHealth;
		
		public float HealthNormalized
		{
			get { return  currentHealth.FloatValue / maxHealth.FloatValue; }
		}
	
		public UnityAction<float, float> healthUpdate = delegate {  };
		public UnityAction healthAtZero = delegate {  };
	
		public void AddHealth(float amount)
		{
		//	Debug.Log("Adding " + amount + " Health");
			currentHealth.FloatValue += amount;
			Debug.Log("CurrentHealth = " + currentHealth.FloatValue);
			if (currentHealth.FloatValue > maxHealth.FloatValue)
			{
				currentHealth.FloatValue = maxHealth.FloatValue;
			}
	
			if (currentHealth.FloatValue <= 0)
			{
				currentHealth.FloatValue = 0;
				
				if(healthAtZero != null)
					healthAtZero();
			}
			
			
			healthUpdate(currentHealth.FloatValue, HealthNormalized);
		//	Debug.Log("Sending Health Update Action");
			
		}
	
		public void SetHealth(float amount)
		{
			currentHealth.FloatValue = amount;
			
			if (currentHealth.FloatValue > maxHealth.FloatValue)
			{
				currentHealth.FloatValue = maxHealth.FloatValue;
			}
	
			if (currentHealth.FloatValue <= 0)
			{
				currentHealth.FloatValue = 0;
				
				if(healthAtZero != null)
					healthAtZero();
			}
			
			healthUpdate(currentHealth.FloatValue, HealthNormalized);
		//	Debug.Log("Sending Health Update Action");
		}
	}
}


