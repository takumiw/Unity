using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour {

	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {

	}

	public void OnClick() {
		audioSource.Play();
		StartCoroutine("GoToScene");
	}

	IEnumerator GoToScene(){
		yield return new WaitForSeconds(0.25f);
		SceneManager.LoadScene("HowToPlay2");
	}
}
