using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SliderValuePass : MonoBehaviour {

	Text progress;

	// Use this for initialization
	void Start () {
		progress = GetComponent<Text>();

	}
	
	public  void UpdateProgress (float content) {
		Debug.Log(Mathf.Round(content));
		progress.text = Mathf.Round( content*100) +"%";
		if(Mathf.Round(content) == 100)
        {
			SceneManager.LoadScene(1);
        }
	}


}
