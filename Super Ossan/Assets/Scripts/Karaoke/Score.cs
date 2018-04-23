using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int score = 0;

	private Text text;

	void Start () {
		text = GetComponent<Text> ();
		AddScore (0);
	}
	
	public void AddScore (int points) {
		score += points;
		text.text = score.ToString ();
	}
}
