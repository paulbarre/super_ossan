using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct NamedStage {
	public string name;
	public GameObject stage;
}

public class StageManager : MonoBehaviour {

	public Stage stage;
	public Text text;
	public Text[] options;
	public NamedStage[] stages;

	void Start () {
		LoadStage ("street");
	}

	void Update () {
		if (!stage) {
			return;
		}
		NamedScript script = stage.GetScript ();
		text.text = script.text;
		for (int i = 0; i < options.Length; i++) {
			options[i].text = i < script.options.Length ? script.options[i] : "";
		}
	}

	public void OptionSelected (int option) {
		stage.OptionSelected (option);
	}

	public void LoadStage (string name) {
		NamedStage namedStage = stages.SingleOrDefault (s => s.name == name);
		if (namedStage.name != name) {
			Debug.LogError ("Stage not found: " + name);
			return;
		}
		if (stage) {
			Destroy (stage.gameObject);
		}
		stage = Instantiate (namedStage.stage).GetComponent<Stage> ();
	}
}
