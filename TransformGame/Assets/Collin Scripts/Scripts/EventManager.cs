using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{

	public enum HeightStates{Car, Robot, Plane}
	public static event UnityAction<HeightStates> OnPlayerChangedHeight = delegate { };
	public static event UnityAction OnPlayerStateCar = delegate { };
	public static event UnityAction OnPlayerStateRobot = delegate { };
	public static event UnityAction OnPlayerStatePlane = delegate { };

	public void ChangePlayerHeightState(string newState)
	{
		switch (newState)
		{
			case "Car":
				OnPlayerChangedHeight(HeightStates.Car);
				OnPlayerStateCar();
				break;
			case "Robot":
				OnPlayerChangedHeight(HeightStates.Robot);
				OnPlayerStateRobot();
				break;
			case "Plane":
				OnPlayerChangedHeight(HeightStates.Plane);
				OnPlayerStatePlane();
				break;
			default:
				break;
		}
	}
}
