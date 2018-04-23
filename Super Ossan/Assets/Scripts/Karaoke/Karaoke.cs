using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Karaoke : MonoBehaviour {

	public float spawningRate = 0.5f;
	public GameObject button;

	private Score score;

	void Start () {
		score = GameObject.FindObjectOfType<Score> ();	
		InvokeRepeating ("InstantiateButtons", 0, spawningRate);
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			foreach (Transform child in transform) {
				foreach (Transform grandchild in child) {
					Destroy (grandchild.gameObject);
					score.AddScore (100);
				}
			}
		}
	}

	void InstantiateButtons () {
		foreach (Transform child in transform) {
			InstantiateButton (child);
		}
	}

	void InstantiateButton (Transform parent) {
		Instantiate (button, parent);
	}
}
