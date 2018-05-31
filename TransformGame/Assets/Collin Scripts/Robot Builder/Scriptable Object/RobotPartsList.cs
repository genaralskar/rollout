using System.Collections;
using System.Collections.Generic;
using System.Resources;
using System.Runtime.InteropServices;
using UnityEngine;

[CreateAssetMenu(menuName = "genaralskar/Robot Parts List")]
public class RobotPartsList : ScriptableObject
{

	public List<PartList> partsList;
	
//	public List<RobotPartHead> Heads;
//	public List<RobotPartTorso> Torsos;
//	public List<RobotPartArms> Arms;
//	public List<RobotPartLegs> Legs;

//	public Dictionary<PartType, RobotPartBase> robotParts; //find a way to serialize dictionaraies to use this

	

	public void AddPart(RobotPartBase newPart)
	{
		if (newPart.partType != null) //only attempt to add the part if it has a partType set
		{
			foreach (var list in partsList)
			{
				if (list.partType == newPart.partType)
				{
					if (!list.parts.Contains(newPart)) //if list does not already contain the new item
					{
						list.parts.Add(newPart);
						Debug.Log("New part " + newPart + " added to list " + list.parts);
						return;
					}
					else
					{
						Debug.Log("List " + list.parts + " already contains " + newPart);
						return;
					}
					
				}
			}
			//if a list with the correct part type does not exist, make a new list with that part type
			partsList.Add(new PartList(newPart.partType, newPart));
			Debug.Log("New list of part types " + newPart.partType + " added");
		}
		else
		{
			Debug.Log(newPart + " does not have a partType set! Fix this to add it to the parts list!");
		}
	}

	public void AddRobot(Robot robot)
	{
		foreach (var part in robot.robotParts)
		{
			AddPart(part);
		}
	}

	public int LengthOfList(PartType partType)
	{
		return ListOfPartType(partType).Count;
	}

	public List<RobotPartBase> ListOfPartType(PartType partType)
	{
		foreach (var list in partsList)
		{
			if (list.partType == partType)
			{
				return list.parts;
			}
		}

		return null;
	}

	public int FindIndexOfPart(RobotPartBase part)
	{

		foreach (var list in partsList)
		{
			if (list.partType == part.partType)
			{
				foreach (var p in list.parts)
				{
					if (p == part)
					{
						return list.parts.IndexOf(p);
					}
				}
			}
		}
		
		Debug.Log("Item " + part + " not found in " + this + ". Reseting to default");
		return 0;
	}

	public void RemoveEmptyEntries()
	{
		foreach (var list in partsList)
		{
			for (int i = list.parts.Count - 1; i > 0; i--)
			{
				if (list.parts[i] == null)
				{
					list.parts.Remove(list.parts[i]);
				}
			}
		}
	}
}

[System.Serializable]
public class PartList
{
	public PartType partType;
	public List<RobotPartBase> parts;

	public PartList(PartType type, RobotPartBase newPart)
	{
		this.partType = type;
		this.parts = new List<RobotPartBase>();
		this.parts.Add(newPart);
	}
}
