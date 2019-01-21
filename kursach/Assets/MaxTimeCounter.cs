using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxTimeCounter : MonoBehaviour {
	public float time;
	public float R = 0.01f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time = Mathf.Sqrt ((2 * OberbeckControls.passedDistance * OberbeckControls.overloadMass * Mathf.Pow (R,2) + 8 * OberbeckControls.plummetMass * Mathf.Pow (OberbeckControls.plummetDist,2)) / (OberbeckControls.overloadMass * Mathf.Pow (R,2) * 9.81f));
			OberbeckControls.maxTime = time;
	}
}
