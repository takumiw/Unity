using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    // ターゲットへの参照
    public Transform target;

    // MainCameraとPlayerとの相対距離
    private Vector3 offset;

	void Start()
	{
        // 自分自身(MainCamera)とtargetとの相対距離を算出
        offset = GetComponent<Transform>().position - target.position;
	}

	void Update () {
        // 自分の座標にtargetの座標を代入する
        GetComponent<Transform>().position = target.position + offset;
	}
}
