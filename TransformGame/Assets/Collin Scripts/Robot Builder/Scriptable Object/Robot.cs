using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

[CreateAssetMenu(menuName = "genaralskar/Robot")]
public class Robot : ScriptableObject 
{
	public RobotPartHead Head;
	public RobotPartTorso Torso;
	public RobotPartArms Arms;
	public RobotPartLegs Legs;

	public RobotBuilder builder;

	public float weight;
	public float armor;


	private GameObject currentHeadObj;
	private GameObject currentTorsoObj;
	private GameObject currentLeftArmObj;
	private GameObject currentRightArmObj;
	private GameObject currentLeftLegObj;
	private GameObject currentRightLegObj;

	public void BuildRobot()
	{
		if (builder != null)
		{
			weight = 0;
			armor = 0;
		
			Head.Construct(this, builder.head);
			Torso.Construct(this, builder.torso);
			Arms.Construct(this, builder.lArm);
			Legs.Construct(this, builder.lLeg);
		}
	}

	public void UpdateHead(GameObject newHead)
	{
		Destroy(currentHeadObj);
		
		currentHeadObj = newHead;
	//	Debug.Log("new head assigned");
			
	}
	
	public void UpdateTorso(GameObject newTorso)
	{
		Destroy(currentTorsoObj);
		currentTorsoObj = newTorso;
	}

	public void UpdateLegs(GameObject newLLeg, GameObject newRLeg)
	{
		Destroy(currentLeftLegObj);
		Destroy(currentRightLegObj);
		
		Transform lLegT = newLLeg.transform;
		lLegT.SetParent(builder.lLeg);
		lLegT.localPosition = Vector3.zero;
		lLegT.localRotation = Quaternion.identity;
		
		Transform rLegT = newRLeg.transform;
		rLegT.SetParent(builder.rLeg);
		rLegT.localPosition = Vector3.zero;
		rLegT.localRotation = Quaternion.identity;
		
		currentLeftLegObj = newLLeg;
		currentRightLegObj = newRLeg;
	}

	public void UpdateArms(GameObject newLArm, GameObject newRArm)
	{
		Destroy(currentLeftArmObj);
		Destroy(currentRightArmObj);
		
		Transform lArmT = newLArm.transform;
		lArmT.SetParent(builder.lArm);
		lArmT.localPosition = Vector3.zero;
		lArmT.localRotation = Quaternion.identity;
		
		Transform rArmT = newRArm.transform;
		rArmT.SetParent(builder.rArm);
		rArmT.localPosition = Vector3.zero;
		rArmT.localRotation = Quaternion.identity;
		
		currentLeftArmObj = newLArm;
		currentRightArmObj = newRArm;
	}
}
