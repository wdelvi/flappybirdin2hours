using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedInputController: MonoBehaviour 
{
    public Jumper controlledJumper;

	// Update is called once per frame
	void Update () 
    {
        if( Input.GetMouseButtonDown(0) )
        {
            controlledJumper.Jump();
        }
	}
}
