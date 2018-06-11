﻿using System.Collections;
using System.Collections.Generic;
using genaralskar;
using RoboRyanTron.Unite2017.Events;
using UnityEngine;

namespace genaralskar
{
	public class Hurtbox : MonoBehaviour
	{
	
		public HealthManager healthManager;
		public GameEvent screenShake;
		public GameEvent hitSound;

		private void OnParticleCollision(GameObject other)
		{
			print("Triggered");
			WeaponManager otherWeapon = other.GetComponent<WeaponManager>();
			healthManager.AddHealth(-otherWeapon.damage);
			screenShake.Raise();
			hitSound.Raise();
		}
	}
}

