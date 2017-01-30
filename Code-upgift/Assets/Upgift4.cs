using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgift4 : MonoBehaviour 
{
	int a = 7;
	int b = -3;
	int c = 4;
	// Use this for initialization
	void Start ()
	{
		if (c > b && c < a) 
		{
			Debug.Log ("C is in between a %% b");	
		} else
		{
			Debug.Log("Failed");
		}

	}
	
	// Update is called once per frame
	void Update ()
	{

	}
}
