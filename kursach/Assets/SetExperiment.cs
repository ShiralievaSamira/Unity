using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetExperiment : MonoBehaviour {
	public GameObject overLoad;
	public bool setExp = false;
	public float timer = 0f;
	public Oberbeck oberbeckValues;
	// Use this for initialization
	void Start () {
		oberbeckValues = GameObject.FindGameObjectWithTag ("GameController").GetComponent<Test> ().test;
	}
	
	// Update is called once per frame
	void Update () {
		if (setExp == true) {
			timer += Time.deltaTime;
			GetComponent<Text> ().text = timer.ToString ("f2");
			overLoad.GetComponent<LocalOverLoad> ().moving = true;
			if (timer > oberbeckValues.MaxTime) {
				overLoad.GetComponent<LocalOverLoad> ().moving = false;
				setExp = false;
			}
		} else {
		
			overLoad.GetComponent<LocalOverLoad> ().moving = false;
			setExp = false;
		}
	}
	public void ExecuteExperiment(){
		setExp = !setExp;
	}

	public void ResetExperiment(){
		timer = 0f;
		GetComponent<Text> ().text = 0.00f.ToString("f2");
		overLoad.GetComponent<LocalOverLoad> ().reset = true;
		setExp = false;

	}
}
