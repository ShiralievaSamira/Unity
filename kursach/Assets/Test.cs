using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	public Oberbeck test;
	// Use this for initialization
	void Start () {
		test = ScriptableObject.CreateInstance<Oberbeck> ();
		//test.UpPRadius ();
		//test.UpDistance ();
	}
	
	// Update is called once per frame
	void Update () {
		test.UpdateTime ();
		//Debug.Log (test.Distance);
	}
}
