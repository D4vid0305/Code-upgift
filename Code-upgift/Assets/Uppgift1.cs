using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgift1 : MonoBehaviour {

	public int a = 7;
	public int b = -3;


	// Use this for initialization
	void Start () 
	{
		// Här säger vi att det ska skrivas ut vad resultat av a+b blir
		Debug.Log ("a" + a);
		Debug.Log ("b" + b);
		int c = a;


		a = b;
		b = c;

		Debug.Log ("Swapped:");
		Debug.Log ("a" + a);
		Debug.Log ("b"+ b);

	}

}
