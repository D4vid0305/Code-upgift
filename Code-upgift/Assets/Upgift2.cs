using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgift2 : MonoBehaviour 
{
	 
	//Here, I value so data has nothing to assume 
	public int a = 7;
	public int b = -3;

	// Use this for initialization
	void Start () 
	{
		//Here we say that if a is greater than b so it should print "Hi!" the console
		if ( a > b)
		{
			Debug.Log ("Grea work you moron"// this is what is suposed to be printed);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
