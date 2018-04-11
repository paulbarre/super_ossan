using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour {

	public Text text;
	public Text[] options;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetText (string text) {
		this.text.text = text;
	}

	public void SetOptions (string[] options) {
		for (int i = 0; i < options.Length; i++) {
			this.options[i].text = options[i];
		}
	}
}
