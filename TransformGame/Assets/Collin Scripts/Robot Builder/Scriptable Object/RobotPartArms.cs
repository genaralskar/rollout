using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "genaralskar/Robot Arms")]
public class RobotPartArms : RobotPartBase
{

	public override void Construct(Robot robot, Transform snapPoint)
    {
        //base.Construct(robot, snapPoint);
        GameObject newObj = Instantiate(part);
        Transform partT = newObj.transform;
        
        GameObject lArm = partT.GetChild(0).gameObject;
        GameObject rArm = partT.GetChild(1).gameObject;
        lArm.transform.SetParent(null);
        rArm.transform.SetParent(null);
        Destroy(newObj);
        
    }
}
