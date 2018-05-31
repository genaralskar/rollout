using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotBuilder : MonoBehaviour {

	public Transform head;
	public Transform torso;
	public Transform lArm;
	public Transform rArm;
	public Transform lLeg;
	public Transform rLeg;

	public Robot robot;

	private void Awake()
	{
		if(robot != null)
			robot.builder = this;
		
		ConstructRobot();
	}

	public void SwapHead(RobotPartHead newHead)
	{
		robot.Head = newHead;
		ConstructRobot();
	//	robot.Head.Construct(robot, head);
	}

	public void SwapTorso(RobotPartTorso newTorso)
	{
		robot.Torso = newTorso;
		ConstructRobot();
	}

	public void SwapArms(RobotPartArms newArms)
	{
		robot.Arms = newArms;
		ConstructRobot();
	}

	public void SwapLegs(RobotPartLegs newLegs)
	{
		robot.Legs = newLegs;
		ConstructRobot();
	}

	public void ConstructRobot()
	{
		robot.BuildRobot();
	}
}
