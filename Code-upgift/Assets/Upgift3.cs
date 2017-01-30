using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgift3 : MonoBehaviour
{

	int Add (int a, int b)
	{
		return a + b;
	}

	// Saker man skriver på denna fälten ska hända bara engång
	// Use this for initialization
	void Start ()
	{
		int Answear = Add (7, -3);
		Debug.Log (Answear);
	}
	
	// Update is called once per frame
	// Saker som skrivs här kommer uprepas så länge vi kör unity eller vad vi nu använder
	void Update () 
	{
		
	}
}
