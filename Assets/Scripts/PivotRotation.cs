using UnityEngine;
using System.Collections;

public class PivotRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectWithTag ("Chosen") != null) {
			if (Background.ChosenColor == "running") {
				if (Input.GetKeyDown ("left")) {
					GameObject PivotPoint;
					PivotPoint = GameObject.FindGameObjectWithTag ("Chosen");
					transform.RotateAround (PivotPoint.transform.position, Vector3.forward, 90);
					Background.Moves++;
				}
				if (Input.GetKeyDown ("right")) {
					GameObject PivotPoint;
					PivotPoint = GameObject.FindGameObjectWithTag ("Chosen");
					transform.RotateAround (PivotPoint.transform.position, Vector3.forward, -90);
					Background.Moves++;
				}
				if (Input.GetKeyDown ("down")) {
					GameObject PivotPoint;
					PivotPoint = GameObject.FindGameObjectWithTag ("Chosen");
					transform.RotateAround (PivotPoint.transform.position, Vector3.forward, 180);
					Background.Moves++;
				}
			}
		}
	}
}
