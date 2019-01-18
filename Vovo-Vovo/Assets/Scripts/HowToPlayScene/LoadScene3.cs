using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene3 : MonoBehaviour {

	public AudioSource audioSource;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		audioSource = gameObject.GetComponent<AudioSource>();
	}

	public void OnClick() {
		audioSource.Play();
		GameObject bgm = GameObject.Find("BGM");
		Destroy(bgm);
		StartCoroutine("GoToScene");
	}

	IEnumerator GoToScene(){
		yield return new WaitForSeconds(0.25f);
		SceneManager.LoadScene("Title");
	}
}
