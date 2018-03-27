using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	private States myState;
	private bool chocolateEquipped;

	private enum States {
		street, trash, club, win, gameover
	}

	void Start () {
		NewGame ();
	}

	void NewGame () {
		myState = States.street;
		chocolateEquipped = false;
	}
	
	void Update () {
		if 		(myState == States.street) 		{ street(); }
		else if (myState == States.trash)	 	{ trash(); }
		else if (myState == States.club) 		{ club(); }
		else if (myState == States.win) 		{ win(); }
		else if (myState == States.gameover)	{ gameover(); }
	}

	#region Trash handler methods
	void street ()
	{
		text.text = "You are in one of those noisy streets of Kabukicho, the pocket full " +
					"enough of money to go to the Friday Princess club.\n" +
					"You'll finally be able to meet your favourite hostess Momo-chan.\n\n" +
					"Press C to enter the Club, or T to have a look to the trash to which a drunk man is talking to.";
		if 		(Input.GetKeyDown (KeyCode.C)) { myState = States.club; }
		else if (Input.GetKeyDown (KeyCode.T)) { myState = States.trash; }
	}

	void trash () {
		if 		(!chocolateEquipped) { trash_0 (); }
		else 						 { trash_1(); }
	}

	void trash_0 () {
		text.text = "A drunk man is talking to the trash. You just ignore him and dive a hand inside " +
					"the trash...\n" +
					"Oh! It seems you got something! You proudly taking out the trash a brand new \n" +
					"box of chocolate. They box looks new... are they still good? Have they ever been?\n\n" +
					"Press R to Return to the street, or T to Take the chocolates.";
		if 		(Input.GetKeyDown (KeyCode.R)) { myState = States.street; }
		else if (Input.GetKeyDown (KeyCode.T)) { chocolateEquipped = true; }
	}

	void trash_1 () {
		text.text = "Old man: Get away from here jerk!\n\n" +
					"The drunk man is pushing you away. It might be better to go " + 
					"back to the street.\n\n" +
					"Press R to Return to the street.";
		if 		(Input.GetKeyDown (KeyCode.R)) { myState = States.street; }
	}
	#endregion

	#region Club handler methods
	void club () {
		text.text = "You are entering the club! Hopefully Momo-chan was not talking to any customer.\n" +
					"Laughing, drinking, you are having fun with this beautiful girl!\n\n" + 
					"Momo-chan: Did you bring me a present? you promised last time you came!\n\n";
		if (chocolateEquipped) {
			text.text += "Press G to give your chocolate, or F to say you forgot.";
			if 		(Input.GetKeyDown (KeyCode.G)) { myState = States.win; }
			else if (Input.GetKeyDown (KeyCode.F)) { myState = States.gameover; }
		} else {
			text.text += "Press F to say you forgot.";
			if (Input.GetKeyDown (KeyCode.F)) { myState = States.gameover; }
		}
	}
	#endregion

	void win () {
		text.text = "Great!! you won the game!\n\n" + 
					"Press P to play again.";
		if 		(Input.GetKeyDown (KeyCode.P)) { NewGame (); }
	}

	void gameover () {
		text.text = "Oops! Momo-chan is so upset. You lost the game pal!\n\n" + 
					"Press P to play again.";
		if 		(Input.GetKeyDown (KeyCode.P)) { NewGame (); }
	}
}
