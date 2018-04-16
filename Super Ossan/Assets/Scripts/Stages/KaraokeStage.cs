using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaraokeStage : Stage {

	void Awake () {
		LoadScript ("karaoke");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void OptionSelected (int option) {

	}
}
