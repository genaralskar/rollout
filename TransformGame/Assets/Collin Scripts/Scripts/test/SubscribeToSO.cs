using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubscribeToSO : MonoBehaviour {

	public SO_SubTest soTest;

	private void Start () {
		soTest.testThis += Testy;
	}

	private void Testy()
	{

	}
	
	
}
