using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClubStage : Stage {

	private enum States {
		club_0, club_1
	};
	private States state;

	void Awake () {
		Player player = GameObject.FindObjectOfType<Player> ();
		ChangeState (!player.hasChocolate ? States.club_0 : States.club_1);
	}

	void ChangeState (States state) {
		this.state = state;
		LoadScript (state.ToString ());
	}

	public override void OptionSelected (int option) {
		if 		(state == States.club_0) { club_0 (option); }
		else if (state == States.club_1) { club_1 (option); }
	}

	void club_0 (int option) {
		ScreenManager screenManager = GameObject.FindObjectOfType<ScreenManager> ();
		if 		(option == 0) { screenManager.LoadScene("Lose"); }
	}

	void club_1 (int option) {
		ScreenManager screenManager = GameObject.FindObjectOfType<ScreenManager> ();
		if 		(option == 0) { screenManager.LoadScene("Lose"); }
		else if (option == 1) { screenManager.LoadScene("Win"); }
	}
}
