using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DangetWall : MonoBehaviour {

	//public GameObject loserLabelObject;

	// オブジェクトと接触した時に呼ばれるコールバック
	void OnCollisionEnter (Collision hit) {

		// 接触したオブジェクトのタグが"Player"の場合
		if (hit.gameObject.CompareTag ("Player")){

　　　　//loserLabelObject.SetActive(true);

			// 現在のシーン番号を取得
			int sceneIndex = SceneManager.GetActiveScene().buildIndex;

			// 現在のシーンを再読み込みする
			SceneManager.LoadScene(sceneIndex);
		}
	}
}
