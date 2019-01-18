using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OjCreate : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("Ojiichan");
        // Cubeプレハブを元に、インスタンスを生成
        Instantiate(obj, new Vector3(0.0f, -2.5f, 0.0f), Quaternion.identity);
    }

	// Update is called once per frame
	void Update () {

	}


}
