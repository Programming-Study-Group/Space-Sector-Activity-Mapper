using UnityEngine;
using System.Collections;

/// <summary>
/// Spin the object at a specified speed
/// </summary>
public class SpinFree : MonoBehaviour {
	[Tooltip("Spin: Yes or No")] public bool spin;
	public float spinSpeed = 10f;
	[HideInInspector] public bool clockwise = true;



	// Update is called once per frame
	void Update() {
		if (spin) {
			if (clockwise) {
				transform.Rotate(-Vector3.up, (spinSpeed * 1f) * Time.deltaTime);
			} else {
				transform.Rotate(-Vector3.up, (spinSpeed * 1f) * Time.deltaTime);
			}
		}
	}
}