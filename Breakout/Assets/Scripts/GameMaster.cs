using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

	public int boxNum;
	public float currentTime;

	// Use this for initialization
	void Start () {
		currentTime = 0;
	}

	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if (boxNum <= 0){
			GameOver(currentTime.ToString("F0") + "秒でクリア！");
		}
	}

	public void GameOver(string resultMessage){
		DataSender.resultMessage = resultMessage;
		SceneManager.LoadScene("Result");
	}
}
