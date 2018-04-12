using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClubStage : Stage {

	void Awake () {
		LoadScript ("club");
	}

	public override void OptionSelected (int option) {
		ScreenManager screenManager = GameObject.FindObjectOfType<ScreenManager> ();
		if 		(option == 0) { screenManager.LoadScene("Lose"); }
		else if (option == 1) { screenManager.LoadScene("Win"); }
	}
}
