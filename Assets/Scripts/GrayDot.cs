using UnityEngine;
using System.Collections;

public class GrayDot : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Background.ChosenColor == "running") {
			GetComponent<Renderer> ().enabled = false;
		} else {
			GetComponent<Renderer> ().enabled = true;
		}
	}

	// Events activated when the user clicks the gray dot
	void OnMouseDown () {
		// 	When the user clicks the gray dot, his/her chosen color changes to gray, 
		//	which then changes their cursor to a gray dot. 
		// 	See Background.cs for more info.
		if (Background.ChosenColor != "running") {
			Background.ChosenColor = "gray";
		}
	}
}
