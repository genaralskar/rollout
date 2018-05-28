using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "genaralskar/Robot Parts List")]
public class RobotPartsList : ScriptableObject {

	public List<RobotPartHead> Heads;
	public List<RobotPartTorso> Torsos;
	public List<RobotPartArms> Arms;
	public List<RobotPartLegs> Legs;

	public void AddRobot(Robot robot)
	{
		AddHead(robot.Head);
		AddTorso(robot.Torso);
		AddArms(robot.Arms);
		AddLegs(robot.Legs);
	}

	public void AddHead(RobotPartHead newHead)
	{
		Heads.Add(newHead);
	}

	public void AddTorso(RobotPartTorso newTorso)
	{
		Torsos.Add(newTorso);
	}

	public void AddArms(RobotPartArms newArms)
	{
		Arms.Add(newArms);
	}

	public void AddLegs(RobotPartLegs newLegs)
	{
		Legs.Add(newLegs);
	}
}
