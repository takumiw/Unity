using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OjJump : MonoBehaviour {

	private GameObject jump1, jump2, jump3, jump4;

	private float time = 0.0f;

	// Use this for initialization
	void Start () {
		jump1 = GameObject.Find("Jump1");
    jump2 = GameObject.Find("Jump2");
		jump3 = GameObject.Find("Jump3");
	  jump4 = GameObject.Find("Jump4");
		jump1.SetActive(true);
		jump2.SetActive(false);
		jump3.SetActive(false);
		jump4.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

		if(time > 0.0f & time < 0.25f){
			jump1.SetActive(true);
			jump4.SetActive(false);
		}
		else if(time > 0.0f & time < 0.5f){
			jump1.SetActive(false);
			jump2.SetActive(true);
		}
		else if(time > 0.0f & time < 0.75f){
			jump2.SetActive(false);
			jump3.SetActive(true);
		}
		else if(time > 0.0f & time < 1.0f){
			time = -0.25f;
			jump3.SetActive(false);
			jump4.SetActive(true);
		}
	}
}
