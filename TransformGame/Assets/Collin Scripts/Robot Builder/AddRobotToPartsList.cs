using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRobotToPartsList : MonoBehaviour
{

	public Robot robot;
	public RobotPartsList partsList;

	private void Start()
	{
		partsList.AddRobot(robot);
	}
}
