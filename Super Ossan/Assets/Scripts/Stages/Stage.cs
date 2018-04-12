using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct NamedScript {
	public string name;
	[TextArea]
	public string text;
	public string[] options;
}

public abstract class Stage : MonoBehaviour {

	public NamedScript[] scripts;

	private NamedScript script;

	void Start () {
	}

	public NamedScript GetScript () {
		return script;
	}

	protected void LoadScript (string name) {
		foreach (NamedScript script in scripts) {
			if (script.name == name) {
				this.script = script;
				break;
			}
		}
		if (script.name != name) {
			Debug.LogError ("Script not found: " + name);
		}
	}

	public abstract void OptionSelected (int option);
}
