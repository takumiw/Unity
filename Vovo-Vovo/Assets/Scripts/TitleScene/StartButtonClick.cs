using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButtonClick : MonoBehaviour {

	public AudioSource audioSource;
    public Text text1;
    

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
		SceneManager.LoadScene("Main");
	}

    public void OnPointerEnter()
    {
        text1.color = Color.green;
    }


}
