using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
	
	// トリガーとの接触時に呼ばれるコールバック
	void OnTriggerEnter (Collider hit) {
		
        // 接触対象がPlayerタグかどうか
        if (hit.CompareTag ("Player")){
            // このコンポーネント(Item)を持つGameObjectを破棄する
            Destroy(gameObject);
        }
	}
}
