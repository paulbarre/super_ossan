using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaraokeSpawner : MonoBehaviour {

	public GameObject button;
	public float spawningRate = 0.5f;

	void Start () {
		InvokeRepeating ("InstantiateButtons", 0, spawningRate);
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
