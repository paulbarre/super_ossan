using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	private States myState;
	private SkillSelection skillSelection;
	private int money;
	private int alcohoolLevel;

	private enum States {
		character_design
	}

	private enum SkillSelection {
		money, alcohool
	}

	void Start () {
		myState = States.character_design;
		skillSelection = SkillSelection.money;
		money = 1000;
	}
	
	void Update () {
		if 		(myState == States.character_design) 		{character_design();}
	}

	#region State handler methods
	void character_design () {
		text.text = "Argent: " + money + "\n" +
					"Alcohool level: " + skillSelection + "\n\n" +
					"Use Up arrow and Down arrow to select skill you want to customize. Press Right arrow to increase your skill, Left arrow to decrease your skill.";
	}
	#endregion
}
