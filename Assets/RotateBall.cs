using UnityEngine;
using System.Collections;

public class RotateBall : MonoBehaviour {

	// Use this for initialization
	public float smooth = 2.0F;
	public float tiltAngle = 30.0F;
	void Update() {
		transform.RotateAround(transform.position, transform.up, Time.deltaTime * 20f);
	}
}
