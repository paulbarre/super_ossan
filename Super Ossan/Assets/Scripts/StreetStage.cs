using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetStage : MonoBehaviour {

	StageManager stageManager;

	// Use this for initialization
	void Start () {
		stageManager = GameObject.FindObjectOfType<StageManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		stageManager.SetText("You are in one of those noisy streets of Kabukicho, the pocket full " +
					"enough of money to go to the Friday Princess club.\n" +
					"You'll finally be able to meet your favourite hostess Momo-chan.\n\n" +
					"Press C to enter the Club, or T to have a look to the trash to which a drunk man is talking to.");
	}
}
