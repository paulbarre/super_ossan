using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Script {
	public string name;
	[TextArea]
	public string text;
	public string[] options;
}

public abstract class Stage : MonoBehaviour {

	public Script[] scripts;

	private Script script;

	public Script GetScript () {
		return script;
	}

	protected void LoadScript (string name) {
		foreach (Script script in scripts) {
			if (script.name == name) {
				this.script = script;
				break;
			}
		}
		if (script.name != name) {
			Debug.LogError ("Script not found: " + name);
		}
	}
}
