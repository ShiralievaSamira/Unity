using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDistance : MonoBehaviour {
	Vector3 position;
	[Range(1f,2.5f)] public float localPos = 1f;
	public Oberbeck oberbeckValues;
	// Use this for initialization
	void Start () {
		oberbeckValues = GameObject.FindGameObjectWithTag ("GameController").GetComponent<Test> ().test;
	}

	// Update is called once per frame
	void Update () {
		localPos = oberbeckValues.Distance;
		transform.localPosition = new Vector3 (localPos*0.1f, transform.localPosition.y, transform.localPosition.z);
	}
}
