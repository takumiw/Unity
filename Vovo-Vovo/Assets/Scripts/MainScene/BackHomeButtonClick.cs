using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackHomeButtonClick : MonoBehaviour {

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
		SceneManager.LoadScene("Title");
	}

}
