using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalOverLoad : MonoBehaviour {
	public bool moving = false;
	public float speed;
	public Transform target;
	public Vector3 startPos;
	public bool reset = false;
	public Transform rotation;
	public Quaternion startRotation;
	public Oberbeck oberbeckValues;
	float distance;
	
	void Start () {
		oberbeckValues = GameObject.FindGameObjectWithTag ("GameController").GetComponent<Test> ().test;
		startPos = transform.position;
		startRotation = rotation.rotation;
		distance = (target.position - transform.position).magnitude;
		speed = (target.localPosition.x / oberbeckValues.MaxTime)*0.1f;
	}
	
	
	void Update () {

			speed = target.localPosition.x/ oberbeckValues.MaxTime;

		if (moving == true) {
			
			transform.localPosition = new Vector3(transform.localPosition.x+speed*Time.deltaTime, transform.localPosition.y,transform.localPosition.z);
			rotation.Rotate (-Vector3.forward * (oberbeckValues.Distance/oberbeckValues.MaxTime)*20);
		}
		if (reset) {
			transform.position = startPos;
			rotation.rotation = startRotation;
			moving = false;
			reset = false;
		}

		if (speed < 0.005f) {
			moving = false;
		}
		print (oberbeckValues.MaxTime + " speed: " + speed + " target x: " + target.localPosition.x);
	}
}
