using UnityEngine;
using System.Collections;

public class CameraPan : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void LateUpdate () {
		transform.LookAt (target);
	}
}
