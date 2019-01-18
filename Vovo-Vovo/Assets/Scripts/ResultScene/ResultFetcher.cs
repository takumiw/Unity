using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultFetcher : MonoBehaviour {

	public int resultScore;
	public UnityEngine.UI.Text scoreLabel;
	private int highScore;
    public GameObject endBGM;

    // Use this for initialization
    void Start () {
        Instantiate(endBGM);
        resultScore = DataSender.resultScore;
		scoreLabel.text = resultScore.ToString();
		highScore = PlayerPrefs.GetInt("highScore", 0);
		if (resultScore > highScore){
			PlayerPrefs.SetInt("highScore", resultScore);
		}
	}

	// Update is called once per frame
	void Update () {
        
    }
}
