using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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

	public int FindIndexOfPart(RobotPartBase part)
	{
		foreach (var p in Heads)
		{
			if (p == part)
			{
				return Heads.IndexOf(p);
			}
		}
		
		foreach (var p in Torsos)
		{
			if (p == part)
			{
				return Torsos.IndexOf(p);
			}
		}
		
		foreach (var p in Arms)
		{
			if (p == part)
			{
				return Arms.IndexOf(p);
			}
		}
		
		foreach (var p in Legs)
		{
			if (p == part)
			{
				return Legs.IndexOf(p);
			}
		}
		
		Debug.Log("Item " + part + " not found in " + this + ". Reseting to default");
		return 0;
	}
}
