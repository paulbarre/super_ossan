using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashStage : Stage {

	private enum States {
		trash_0, trash_1
	};
	private States state;
	private Player player;
	
	void Awake () {
		player = GameObject.FindObjectOfType<Player> ();
		ChangeState (!player.hasChocolate ? States.trash_0 : States.trash_1);
	}

	public override void OptionSelected (int option) {
		if 		(state == States.trash_0) { trash_0 (option); }
		else if (state == States.trash_1) { trash_1 (option); }
	}

	void ChangeState (States state) {
		this.state = state;
		LoadScript (state.ToString ());
	}

	void trash_0 (int option) {
		if 		(option == 0) { GameObject.FindObjectOfType<StageManager> ().LoadStage ("street"); }
		else if (option == 1) { 
			GameObject.FindObjectOfType<Player> ().hasChocolate = true;
			ChangeState (States.trash_1); 
		}
	}

	void trash_1 (int option) {
		if 		(option == 0) { GameObject.FindObjectOfType<StageManager> ().LoadStage ("street"); }
	}
}
