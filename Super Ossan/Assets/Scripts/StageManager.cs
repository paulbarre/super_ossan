using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour {

	public Stage stage;
	public Text text;
	public Text[] options;

	void Update () {
		Script script = stage.GetScript ();
		text.text = script.text;
		for (int i = 0; i < options.Length; i++) {
			options[i].text = i < script.options.Length ? script.options[i] : "";
		}
	}
}
