using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Translate (-0.01f, 0, 0);
		if (this.transform.position.x < -30.61202f) {
			this.transform.position = new Vector3 (30.61202f, 0, 0);
		}
}
}
