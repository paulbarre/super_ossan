using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Karaoke : MonoBehaviour {

	public float spawningRate = 0.5f;
	public GameObject button;

	private Score score;
	private List<Spawner> spawners;

	void Start () {
		score = GameObject.FindObjectOfType<Score> ();	
		spawners = new List<Spawner> ();
		foreach (Transform child in transform) {
			Spawner spawner = child.gameObject.GetComponent<Spawner> ();
			if (spawner) {
				spawners.Add (spawner);
			}
		}
		InvokeRepeating ("InstantiateButtons", 0, spawningRate);
	}

	void Update () {
		
	}

	void InstantiateButtons () {
		foreach (Spawner spawner in spawners) {
			spawner.Spawn ();
		}
	}
}
