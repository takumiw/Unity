using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public UnityEngine.UI.Text score_label;
	public UnityEngine.UI.Text hp_label;
	public UnityEngine.UI.Text timer_label;


	private int prev_score;
	private int prev_hp;
	private float prev_second;

	public static int score;
	private int hp;
	private int minute;
	private float second;

	private GameObject heart1;
	private GameObject heart2;
	private GameObject heart3;

	//private string[] hearts = ["Heart1", "Heart2", "Heart3"];

	// Use this for initialization
	void Start () {
				heart1 = GameObject.Find("Heart1");
				heart2 = GameObject.Find("Heart2");
				heart3 = GameObject.Find("Heart3");

				prev_second = 0.0f;
				prev_hp = 3;
				prev_score = 0;

				minute = 0;
				second = 0.0f;
				score = 0;
				hp = 3;

				score_label.text = score.ToString();
				hp_label.text = hp.ToString();
				timer_label.text = minute.ToString("00")+":"+(second).ToString();
	}

	// Update is called once per frame
	void Update () {
				if (score != prev_score){
					score_label.text = score.ToString();
					prev_score = score;
				}

				if (hp < prev_hp){
					if(hp == 2){
						heart3.SetActive(false);
					}
					else if (hp == 1){
						heart2.SetActive(false);
					}
					else if (hp == 0){
						heart1.SetActive(false);
					}
					prev_hp = hp;
				}
				else if (hp > prev_hp){
					if(hp == 3){
						heart3.SetActive(true);
					}
					else if (hp == 2){
						heart2.SetActive(true);
					}
					else if (hp == 1){
						heart1.SetActive(true);
					}
					prev_hp = hp;
				}

				if (second != prev_second){
					timer_label.text = minute.ToString("00") + ":" 
                +((int) second).ToString("00") + ":"
                +(second - (int)second).ToString().Substring(2,1);
					prev_second = second;
				}

				second += Time.deltaTime;
				if (second >= 60.0f){
					minute ++;
					second -= 60.0f;
				}

				if (hp <= 0){
					GameOVer();
				}

	}

	// ポイントの追加をする
	public void AddPoint (int point) {
				score += point;
	}

	public void DecreaseHp () {
				hp -= 1;
	}

	public void IncreaseHp(){
		if (hp < 3){
			hp += 1;
		}
	}

	public void GameOVer(){
		DataSender.resultScore = score;
		SceneManager.LoadScene("ResultHS");
	}
}
