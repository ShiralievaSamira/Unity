using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oberbeck : ScriptableObject{
	
	public Oberbeck () : this (1f, 0.001f, 0.001f, 0.001f, 0.05f, 5f){}

	public Oberbeck (float distance, float overloadMass, float plummetRadius, float plummetMass, float plummetDist, float maxTime){
		this.Distance = distance;
		this.OverloadMass = overloadMass;
		this.PlummetMass = plummetMass;
		this.PlummetDist = plummetDist;
		this.PlummetRadius = plummetRadius;
		this.MaxTime = maxTime;
	}

	public float Distance {
		get;
		private set;
	}
	public float OverloadMass {
		get;
		private set;
	}
	public float PlummetRadius {
		get;
		private set;
	}
	public float PlummetMass {
		get;
		private set;
	}
	public float PlummetDist {
		get;
		private set;
	}
	public float MaxTime {
		get;
		private set;
	}

	public void UpDistance(){
		if (Distance >= 2.5f) {
			Distance = 2.5f;
		} else {
			Distance += 0.01f;
		}

	}
	public void DownDistance(){
		if (Distance <= 1f) {
			Distance = 1f;
		} else {
			Distance -= 0.01f;
		}
	}
	public void UpOverloadMass(){
		if (OverloadMass >= 0.5f) {
			OverloadMass = 0.5f;
		} else {
			OverloadMass += 0.001f;
		}
	}
	public void DownOverloadMass(){
		if (OverloadMass <= 0.001f) {
			OverloadMass = 0.001f;
		} else {
			OverloadMass -= 0.001f;
		}
	}
	public void UpPRadius(){
		if (PlummetRadius >= 0.01f) {
			PlummetRadius = 0.01f;
		} else {
			PlummetRadius += 0.001f;
		}
	}
	public void DownPRadius(){
		if (PlummetRadius <= 0.001f) {
			PlummetRadius = 0.001f;
		} else {
			PlummetRadius -= 0.001f;
		}
	}
	public void UpPMass(){
		if (PlummetMass >= 0.5f) {
			PlummetMass = 0.5f;
		} else {
			PlummetMass += 0.001f;
		}
	}
	public void DownPMass(){
		if (PlummetMass <= 0.001f) {
			PlummetMass = 0.001f;
		} else {
			PlummetMass -= 0.001f;
		}

	}
	public void UpPDist(){
		if (PlummetDist >= 0.5f) {
			PlummetDist = 0.5f;
		} else {
			PlummetDist += 0.01f;
		}
	}
	public void DownPDist(){
		if (PlummetDist <= 0.05f) {
			PlummetDist = 0.05f;
		} else {
			PlummetDist -= 0.01f;
		}
	}
	public void UpdateTime(){
		MaxTime = Mathf.Sqrt ((2 * Distance * (4 * PlummetMass * Mathf.Pow (PlummetDist, 2) + OverloadMass * Mathf.Pow (PlummetRadius, 2))) / (PlummetMass * Mathf.Pow (PlummetRadius, 2) * 9.81f));
	}
}

