using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObFall: MonoBehaviour {

	Vector3 power_dir = Vector3.down;
	//Rigidbody rb;
  //public int move_speed = 500;


	void Start () {
				int fall_speed = (GameController.score / 50) * 100 + 100;
        gameObject.GetComponent<Rigidbody>().AddForce(power_dir * fall_speed);
				//rb = GetComponent<Rigidbody>();
    }

	void Update () {
		if (this.transform.position.y < -5.0f){
			Destroy(this.gameObject);
		}
		/*GameObject obj_oj = GameObject.FindGameObjectWithTag("OjiichanToDelete");
		if (obj_oj){
			Vector3 oj_loc = obj_oj.transform.position;
			if (oj_loc.x <= -3.0f){
				Destroy(obj_oj);
			}
			obj_oj.transform.position -= new Vector3 (0.04f, 0, 0);
		}*/
  }
	// トリガーとの接触時に呼ばれるコールバック
	void OnTriggerEnter (Collider hit){
		if (hit.CompareTag ("Ojiichan")) {
			// アニメーションを再生

			// とりあえず、消えるようにする
			/*GameObject obj_oj0 = GameObject.Find("Ojiichan(Clone)");
			obj_oj0.tag = "OjiichanToDelete";
			GameObject obj_oj = GameObject.FindGameObjectWithTag("OjiichanToDelete");
			obj_oj.layer = LayerMask.NameToLayer("OjiichanToDelete");*/
			Destroy(this.gameObject);
			// Destroy(obj_oj);

			// おじいちゃんに左方向に力を加える
			//int move_speed = 500;
			//Vector3 oj_power_dir = Vector3.left;
			//obj_oj.GetComponent<Rigidbody>().AddForce(oj_power_dir * move_speed);

			//rb.velocity = new Vector3(move_speed, rb.velocity.y, 0);





			// スコアに加点
			FindObjectOfType<GameController>().AddPoint(10);

			// 新しいおじいちゃんを発生させる
			// CubeプレハブをGameObject型で取得
			/*GameObject obj = (GameObject)Resources.Load("Ojiichan");
			// Cubeプレハブを元に、インスタンスを生成
			Instantiate(obj, new Vector3(0.0f, -2.5f, 0.0f), Quaternion.identity);*/
    }
		else if (hit.CompareTag ("Floor")) {
			// DAMAGE ANIMATION AND DECREASE HP
			FindObjectOfType<GameController>().DecreaseHp();
		}
	}

}
