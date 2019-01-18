using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OjController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

    // Update is called once per frame
    void Update() {

				GameObject obj_oj = GameObject.FindGameObjectWithTag("Ojiichan");
        //Vector3 pos = obj_oj.transform.position;

					Vector3 pos = transform.position;


					if (pos.x <= 3 & pos.x >= -3) {

	            if (Input.GetKey(KeyCode.LeftArrow)) {
								if (transform.tag == "Ojiichan"){
	                pos.x -= 0.08f;
								}
	                transform.position = pos;
	            }
	            else if (Input.GetKey(KeyCode.RightArrow)) {
								if (transform.tag == "Ojiichan"){
	                pos.x += 0.08f;
								}
	                transform.position = pos;
	            }
	        }
					//if (transform.tag == "Ojiichan"){
						transform.position = new Vector3(Mathf.Clamp(pos.x, -3, 3), -2.5f, 0);
				//}
	}

}
