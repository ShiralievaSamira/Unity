using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OberbeckControls : MonoBehaviour {
	public static float passedDistance = 1f;
	public static float overloadMass = 0.001f;
	public static float plummetRadius = 0.1f;
	public static float plummetOtherMeters = 0.1f;
	public static float plummetMass = 0.001f;
	public static float plummetDist = 0.05f;
	public static float maxTime = 4f;

	
	// Update is called once per frame
	void Update () {
		if (passedDistance <= 1f) {
			passedDistance = 1f;
		}
		if (passedDistance > 2.5f) {
			passedDistance = 2.5f;
		}

		if (overloadMass <= 0.001f) {
			overloadMass = 0.001f;
		}
		if (overloadMass > 0.5f) {
			overloadMass = 0.5f;
		}
		if (plummetDist <= 0.05f) {
			plummetDist = 0.05f;
		}
		if (plummetDist > 0.5f) {
			plummetDist = 0.5f;
		}
	}
	void LateUpdate(){
		passedDistance = Mathf.Round (passedDistance *100f)*0.01f;
	}

}
