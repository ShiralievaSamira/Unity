using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailObject : MonoBehaviour {
	public Transform trailed;
	LineRenderer lr;
	// Use this for initialization
	void Start () {
		lr = GetComponent<LineRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		lr.SetPosition(1,new Vector3(lr.GetPosition(1).x,trailed.position.y,lr.GetPosition(1).z));
	}
}
