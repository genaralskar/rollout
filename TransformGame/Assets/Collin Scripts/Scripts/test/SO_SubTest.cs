using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SO_SubTest : ScriptableObject {

	public event UnityAction testThis;

	public void Doobee()
	{
		testThis();
	}

}
