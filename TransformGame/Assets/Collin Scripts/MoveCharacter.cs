using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{

	public CharacterMovement movePattern;
	private CharacterController cc;
	
	// Use this for initialization
	private void Start ()
	{
		cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	private void Update () {
		//movePattern.Move(cc, transform);
	}
}
