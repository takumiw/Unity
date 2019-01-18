using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCreate : MonoBehaviour {

	// time unit: [second]

	[SerializeField] float time_create_next;
	private float time_elapsed;

	// Use this for initialization
	void Start () {
		time_elapsed = 0f;
		time_create_next = Random.Range(10.0f, 13.0f);

	}

	// Update is called once per frame
	void Update () {
		time_elapsed += Time.deltaTime;

		if (time_elapsed > time_create_next) {
			CreateHeart();
		}

	}

	void CreateHeart() {
				var create_loc = Random.Range(-3.2f, 3.2f);

				// CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("Heart");

        // Cubeプレハブを元に、インスタンスを生成
				Instantiate(obj, new Vector3(create_loc, 7.0f, 0.0f), Quaternion.identity);

				time_elapsed = 0f;
				time_create_next = Random.Range(5.0f, 7.0f);
	}
}
