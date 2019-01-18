using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObCreate : MonoBehaviour {

	// time unit: [second]

	[SerializeField] float time_create_next;
	private float time_elapsed;

	void Start () {
				time_elapsed = 0f;
				CreateOb();
    }

	void Update () {
				time_elapsed += Time.deltaTime;

				if (time_elapsed > time_create_next) {
					CreateOb();
				}
	}

	void CreateOb() {
				var create_loc = Random.Range(-3.2f, 3.2f);

				// CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("Obaachan");

        // Cubeプレハブを元に、インスタンスを生成
				Instantiate(obj, new Vector3(create_loc, 7.0f, 0.0f), Quaternion.identity);

				time_elapsed = 0f;
				time_create_next = Random.Range(2.0f, 3.5f);
	}
}
