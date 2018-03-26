using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	private States myState;

	private enum States {
		street, trash, club
	}

	void Start () {
		myState = States.street;
	}
	
	void Update () {
		if 		(myState == States.street) 		{ street(); }
		else if (myState == States.trash) 		{ trash(); }
		else if (myState == States.club) 		{ club(); }
	}

	#region State handler methods
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
		text.text = "A drunk man is talking to the trash. You just ignore him and dive a hand inside " +
					"the trash...\n" +
					"Oh! It seems you got something! You proudly taking out the trash a brand new \n" +
					"box of chocolate. They look new and the box does not smeel bad. Maybe Momo-chan would be \n" +
					"happy to get them!\n\n" +
					"Press S to go back to the Street.";
		if 		(Input.GetKeyDown (KeyCode.S)) { myState = States.street; }
	}

	void club () {
	}
	#endregion
}
