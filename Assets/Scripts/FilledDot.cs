using UnityEngine;
using System.Collections;

public class FilledDot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Background.ChosenColor == "") {
			Destroy (gameObject);
		}
	}
}
