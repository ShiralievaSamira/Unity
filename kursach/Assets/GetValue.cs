using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetValue : MonoBehaviour {

	public enum MeasureStates {Distance, Overload, pRadius, pMass, pDist}
	public Oberbeck oberbeckValues;
	public MeasureStates State;
	void Start(){
		oberbeckValues = GameObject.FindGameObjectWithTag ("GameController").GetComponent<Test> ().test;
	}
	// Update is called once per frame
	void Update () {
		switch(State){
		case MeasureStates.Distance:
			GetComponent<Text> ().text = oberbeckValues.Distance.ToString ("f2") + " m";
			break;
		case MeasureStates.Overload:
			GetComponent<Text> ().text = oberbeckValues.OverloadMass.ToString ("f3") + " kg";
			break;
		case MeasureStates.pRadius:
			GetComponent<Text> ().text = oberbeckValues.PlummetRadius.ToString ("f3") + " m";
			break;
		case MeasureStates.pMass:
			GetComponent<Text> ().text = oberbeckValues.PlummetMass.ToString ("f3") + " kg";
			break;
		case MeasureStates.pDist:
			GetComponent<Text> ().text = oberbeckValues.PlummetDist.ToString ("f2") + " m";
			break;
		}
	}
}
