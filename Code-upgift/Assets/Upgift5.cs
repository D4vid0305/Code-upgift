using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgift5 : MonoBehaviour
{
	public int min;
	public int max;

	int Add (int a, int b)
	{
		return a + b;
	}
	// Use this for initialization
	void Start () 
	{
		int Answear = Add (7, -3);
		if (Answear < max && Answear > min)
		{
			Debug.Log("yeah!!!");
		}
	}

	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
