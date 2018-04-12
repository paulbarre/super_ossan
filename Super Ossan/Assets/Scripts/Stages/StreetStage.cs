using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetStage : Stage {
	
	void Awake () {
		LoadScript ("street");
	}

	public override void OptionSelected (int option) {
		StageManager stageManager = GameObject.FindObjectOfType<StageManager> ();
		if 		(option == 0) { stageManager.LoadStage ("club"); }
		else if (option == 1) { stageManager.LoadStage ("trash"); }
	}
}