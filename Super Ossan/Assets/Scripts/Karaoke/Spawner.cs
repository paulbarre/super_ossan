using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Button button;

	void OnDrawGizmos () {
		Gizmos.DrawWireSphere (transform.position, 1);
	}

	public void Spawn () {
		Instantiate (button, transform);
	}
}
