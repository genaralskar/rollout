using System.Collections;
using System.Collections.Generic;
using genaralskar;
using UnityEngine;
using UnityEngine.UI;

public class UIHealth : MonoBehaviour
{

	[SerializeField] private Image healthBar;
	public HealthManager healthManager;

	private void Start()
	{
		healthManager.healthUpdate += UpdateUI;
	//	print("assigned method");
	}

	private void UpdateUI(float currentHealth, float normalizedHealth)
	{
		healthBar.fillAmount = normalizedHealth;
		print("fillbar updating, " + normalizedHealth);
	}
	
}
