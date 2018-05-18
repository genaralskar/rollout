using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal.Builders;
using UnityEngine;

namespace genaralskar
{
	public class SpawnSOProjectile : MonoBehaviour
    {
    	public SO_Projectile projectile;
    	private bool canSpawn = true; //used for cooldown

	    public int layerIndex = 1; //find a way to use layermasks and invert it
    
    	public void Spawn()
    	{
    		if (canSpawn)
    		{
    			StopAllCoroutines();
    			StartCoroutine(SpawnTimer());
    			
			    GameObject tempProjectile = Instantiate(projectile.ProjectilePrefab);
			    tempProjectile.layer = layerIndex;
			    tempProjectile.transform.position = this.transform.position;
			    tempProjectile.transform.rotation = this.transform.rotation;
			    if (projectile.Parent)
			    {
				    tempProjectile.transform.SetParent(this.transform);
			    }
                Destroy(tempProjectile, projectile.ProjectileLifetime);
    		}
    	}
    
    	private IEnumerator SpawnTimer()
    	{
    		canSpawn = false;
    		yield return new WaitForSeconds(projectile.Cooldown);
    		canSpawn = true;
    	}
    }
}

