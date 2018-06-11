using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapParts : MonoBehaviour {

	
	public RobotMakerV2 maker;
	
	[Tooltip("List of parts the player can pick from")]
	public RobotPartsList parts;
	
	private int currentHead = 0;
	private int currentTorso = 0;
	private int currentArms = 0;
	private int currentLegs = 0;
	
	private List<CurrentPartIndex> partIndexess;
	private Dictionary<PartType, int> partIndexes;

	private void OnEnable()
	{
		
		//find index of current robot parts in parts list
		//set current robot parts to that int
//		currentHead = parts.FindIndexOfPart(builder.robot.Head);
//		currentTorso = parts.FindIndexOfPart(builder.robot.Torso);
//		currentArms = parts.FindIndexOfPart(builder.robot.Arms);
//		currentLegs = parts.FindIndexOfPart(builder.robot.Legs);
		FindCurrentIndexes();
		Debug.Log(partIndexes);

	}

	public void FindCurrentIndexes()
	{
		if (partIndexes == null)
		{
			partIndexes = new Dictionary<PartType, int>();
		}
		
		foreach (var part in maker.robotToBuild.robotParts)
		{
			if (!partIndexes.ContainsKey(part.partType)) //if dictionary does not contain key of partType
			{
				partIndexes.Add(part.partType, parts.FindIndexOfPart(part));
			}
			else
			{
				partIndexes[part.partType] = parts.FindIndexOfPart(part);
			}
		}
	}

	public void NextPart(PartType partType)
	{
		partIndexes[partType]++;
		if (partIndexes[partType] > parts.LengthOfList(partType) - 1)
		{
			partIndexes[partType] = 0;
		}
		maker.SwapPart(parts.ListOfPartType(partType)[partIndexes[partType]]);
	}

	public void PreviousPart(PartType partType)
	{
		partIndexes[partType]--;
		if (partIndexes[partType] < 0)
		{
			partIndexes[partType] = parts.LengthOfList(partType) - 1;
		}
		maker.SwapPart(parts.ListOfPartType(partType)[partIndexes[partType]]);
	}

//	public void NextHead()
//	{
//		currentHead++;
//		if(currentHead > parts.Heads.Count - 1)
//			currentHead = 0;
//		
//		print("building head");
//		builder.SwapHead(parts.Heads[currentHead]);
//		maker.SwapPart(parts.Heads[currentHead]);
//		maker.BuildRobot();
//		print("buildt head");
//		//UpdateHead();
//	}
//
//	public void ChangeHeadSelectction(int amount)
//	{
//		currentHead += amount;
//		if (currentHead < 0)
//		{
//			currentHead = parts.Heads.Count - 1;
//		}
//		else if(currentHead > parts.Heads.Count - 1)
//		{
//			currentHead = 0;
//		}
//		builder.SwapHead(parts.Heads[currentHead]);
//	}
//
//	public void PreviousHead()
//	{
//		currentHead--;
//		if(currentHead < 0)
//			currentHead = parts.Heads.Count - 1;
//		builder.SwapHead(parts.Heads[currentHead]);
//		//UpdateHead();
//	}
//
//	public void NextTorso()
//	{
//		currentTorso++;
//		if(currentTorso > parts.Torsos.Count - 1)
//			currentTorso = 0;
//		
//		print("building torso");
//		builder.SwapTorso(parts.Torsos[currentTorso]);
//	}
//
//	public void PreviousTorso()
//	{
//		currentTorso--;
//		if(currentTorso < 0)
//			currentTorso = parts.Torsos.Count - 1;
//		builder.SwapTorso(parts.Torsos[currentTorso]);
//	}
//
//	public void NextArms()
//	{
//		currentArms++;
//		if(currentArms > parts.Arms.Count - 1)
//			currentArms = 0;
//		builder.SwapArms(parts.Arms[currentArms]);
//	}
//
//	public void PreviousArms()
//	{
//		currentArms--;
//		if(currentArms < 0)
//			currentArms = parts.Arms.Count - 1;
//		builder.SwapArms(parts.Arms[currentArms]);
//	}
//
//	public void NextLegs()
//	{
//		currentLegs++;
//		if(currentLegs > parts.Legs.Count - 1)
//			currentLegs = 0;
//		builder.SwapLegs(parts.Legs[currentLegs]);
//	}
//
//	public void PreviousLegs()
//	{
//		currentLegs++;
//		if(currentLegs > 0)
//			currentLegs = parts.Legs.Count - 1;
//		builder.SwapLegs(parts.Legs[currentLegs]);
//	}

}

public class CurrentPartIndex
{
	public int currentIndex;
	public PartType partType;

	public CurrentPartIndex(PartType partType)
	{
		this.partType = partType;
	}
}