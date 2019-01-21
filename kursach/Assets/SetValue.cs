using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetValue : MonoBehaviour {
	//public GameObject settedObj;
	Oberbeck oberbeckFloats;
	//public float multiplier = 0.01f;

	void Start(){
		oberbeckFloats = GameObject.FindGameObjectWithTag ("GameController").GetComponent<Test> ().test;
	}

	public void UpDistance(){
		oberbeckFloats.UpDistance();
	}
	public void DownDistance(){
		oberbeckFloats.DownDistance();
	}
	public void UpOverloadMass(){
		oberbeckFloats.UpOverloadMass();
	}
	public void DownOverloadMass(){
		oberbeckFloats.DownOverloadMass ();
	}
	public void UpPRadius(){
		oberbeckFloats.UpPRadius ();
	}
	public void DownPRadius(){
		oberbeckFloats.DownPRadius ();
	}
	public void UpPMass(){
		oberbeckFloats.UpPMass ();
	}
	public void DownPMass(){
		oberbeckFloats.DownPMass ();
	}
	public void UpPDist(){
		oberbeckFloats.UpPDist ();
	}
	public void DownPDist(){
		oberbeckFloats.DownPDist ();
	}
}
