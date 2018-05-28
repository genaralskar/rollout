using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapParts : MonoBehaviour {

	
	public RobotBuilder builder;
//	public List<RobotPartHead> heads;
	private int currentHead = 0;
//	public List<RobotPartTorso> torsos;
	private int currentTorso = 0;
//	public List<RobotPartArms> arms;
	private int currentArms = 0;
//	public List<RobotPartLegs> legs;
	private int currentLegs = 0;

	public RobotPartsList parts;



//	public Transform headSnapPoint;
//	public Transform torsoSnapPoint;
//	public Transform leftArmSnapPoint;
//	public Transform rightArmSnapPoint;
//	public Transform leftLegSnapPoint;
//	public Transform rightLegSnapPoint;

	// private GameObject currentHeadObj;
	// private GameObject currentTorsoObj;
	// private GameObject currentLeftArmObj;
	// private GameObject currentRightArmObj;
	// private GameObject currentLeftLegObj;
	// private GameObject currentRightLegObj;

	private void OnEnable()
	{
		UpdateAll();
	}

	public void NextHead()
	{
		currentHead++;
		if(currentHead > parts.Heads.Count - 1)
			currentHead = 0;
		builder.SwapHead(parts.Heads[currentHead]);
		//UpdateHead();
	}

	public void ChangeHeadSelectction(int amount)
	{
		currentHead += amount;
		if (currentHead < 0)
		{
			currentHead = parts.Heads.Count - 1;
		}
		else if(currentHead > parts.Heads.Count - 1)
		{
			currentHead = 0;
		}
		builder.SwapHead(parts.Heads[currentHead]);
	}

	public void PreviousHead()
	{
		currentHead--;
		if(currentHead < 0)
			currentHead = parts.Heads.Count - 1;
		builder.SwapHead(parts.Heads[currentHead]);
		//UpdateHead();
	}

	public void NextTorso()
	{
		currentTorso++;
		if(currentTorso > parts.Torsos.Count - 1)
			currentTorso = 0;
		builder.SwapTorso(parts.Torsos[currentHead]);
	}

	public void PreviousTorso()
	{
		currentTorso--;
		if(currentTorso < 0)
			currentTorso = parts.Torsos.Count - 1;
		builder.SwapTorso(parts.Torsos[currentHead]);
	}

	public void NextArms()
	{
		currentArms++;
		if(currentArms > parts.Arms.Count - 1)
			currentArms = 0;
		builder.SwapArms(parts.Arms[currentHead]);
	}

	public void PreviousArms()
	{
		currentArms--;
		if(currentArms < 0)
			currentArms = parts.Arms.Count - 1;
		builder.SwapArms(parts.Arms[currentHead]);
	}

	public void NextLegs()
	{
		currentLegs++;
		if(currentLegs > parts.Legs.Count - 1)
			currentLegs = 0;
		builder.SwapLegs(parts.Legs[currentHead]);
	}

	public void PreviousLegs()
	{
		currentLegs++;
		if(currentLegs > 0)
			currentLegs = parts.Legs.Count - 1;
		builder.SwapLegs(parts.Legs[currentHead]);
	}


	public void UpdateAll()
	{
		UpdateHead();
		UpdateTorso();
		UpdateArms();
		UpdateLegs();
	}

	public void UpdateHead()
	{
		//snapPoints.SwapHead(heads[currentHead]);
		// constructor.Head = heads[currentHead];
		// constructor.BuildRobot();
	}

	public void UpdateTorso()
	{
		//constructor.Torso = torsos[currentTorso];
		//constructor.UpdateTorso(torsoSnapPoint);
	}

	public void UpdateArms()
	{

	}

	public void UpdateLegs()
	{

	}
	
}
