using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{

	public enum HeightStates{Car, Robot, Plane}
	public static event UnityAction<HeightStates> PlayerChangedHeight = delegate { };

	public void ChangePlayerHeightState(string newState)
	{
		switch (newState)
		{
			case "Car":
				PlayerChangedHeight(HeightStates.Car);
				break;
			case "Robot":
				PlayerChangedHeight(HeightStates.Robot);
				break;
			case "Plane":
				PlayerChangedHeight(HeightStates.Plane);
				break;
			default:
				break;
		}
	}
}
