using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour {

	public void LifetimeDisable(float time)
	{
		StartCoroutine(DisableAfterLifetime(time));
	}
		
	private IEnumerator DisableAfterLifetime(float time)
	{
		yield return new WaitForSeconds(time);
		gameObject.SetActive(false);
	}
}
