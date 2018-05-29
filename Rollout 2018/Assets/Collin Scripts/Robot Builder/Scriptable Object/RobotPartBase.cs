using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RobotPartBase : ScriptableObject
{
	public GameObject part;
	protected GameObject instancePart;

	public float weight = 1;
	public float armor = 1;

	public virtual void Construct(Robot robot, Transform snapPoint)
	{	
		GameObject newObj = Instantiate(part);
		Transform partT = newObj.transform;
		Debug.Log(snapPoint);

		partT.SetParent(snapPoint);
		partT.localPosition = Vector3.zero;
		partT.localRotation = Quaternion.identity;
		instancePart = newObj;

		robot.weight += weight;
		robot.armor += armor;
	}
}
