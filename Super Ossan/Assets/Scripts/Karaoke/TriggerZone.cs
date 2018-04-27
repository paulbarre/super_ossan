using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collider) {
		collider.gameObject.transform.SetParent (transform);
	}

	void OnTriggerExit2D (Collider2D collider) {
		collider.gameObject.transform.SetParent (transform.parent);
	}

	void Update () {
		foreach (Transform child in transform) {
			Button button = child.gameObject.GetComponent<Button> ();
			if (button && Input.GetKeyDown (button.trigger)) {
				Destroy (child.gameObject);
			}
		}
	}
}
