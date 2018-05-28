using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "genaralskar/Robot Legs")]
public class RobotPartLegs : RobotPartBase
{

	public override void Construct(Robot robot, Transform snapPoint)
	{
	    //base.Construct(robot, snapPoint);
		GameObject newObj = Instantiate(part);
		Transform partT = newObj.transform;
		
        GameObject lLeg = partT.GetChild(0).gameObject;
        GameObject rLeg = partT.GetChild(1).gameObject;
		lLeg.transform.SetParent(null);
		rLeg.transform.SetParent(null);
		Destroy(newObj);
        robot.UpdateLegs(lLeg, rLeg);
    }
}
