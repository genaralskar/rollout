using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

	public ParticleSystem particle;
	[Range(0,10)]public int damage;

	public void PlayParticle()
	{
		particle.Play();
	}

}
