using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPosition : MonoBehaviour {

	void OnDrawGizmos () {
		Gizmos.DrawWireSphere (transform.position, 1);
	}
}
