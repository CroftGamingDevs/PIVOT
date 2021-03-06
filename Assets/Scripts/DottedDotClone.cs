﻿using UnityEngine;
using System.Collections;

public class DottedDotClone : MonoBehaviour {

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
	void OnMouseDown () {
		
		if (Background.ChosenColor == "gray") {
			Instantiate (Background.GrayDotGameObject, gameObject.transform.position, gameObject.transform.rotation);
			Destroy (gameObject);
		} else if (Background.ChosenColor == "blue") {
			GameObject BlueDotClone;
			BlueDotClone = Instantiate (Background.BlueDotGameObject, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
			BlueDotClone.transform.parent = Background.BlueObject.transform;
			Destroy (gameObject);
		}

	}
	void OnTriggerEnter2D (Collider2D coll) {

		if (coll.gameObject.tag == "Blue") {
			GameObject ChosenTag = GameObject.FindGameObjectWithTag ("Chosen");
			Instantiate (Background.BlueDotGameObject, ChosenTag.transform.position, gameObject.transform.rotation);
			Destroy (ChosenTag);
			Background.BlueTag = GameObject.FindGameObjectsWithTag ("Blue");
			for (int i = 0; i < Background.BlueTag.Length; i++) {
				Destroy (Background.BlueTag [i]);
				GameObject BlueObjectClone;
				BlueObjectClone = Instantiate (Background.BlueDotGameObject, Background.BluePos [i], gameObject.transform.rotation) as GameObject;
				BlueObjectClone.transform.parent = Background.BlueObject.transform;
			}
			Background.FilledTag = GameObject.FindGameObjectsWithTag ("Filled");
			for (int i = 0; i < Background.FilledTag.Length; i++) {
				Instantiate (Background.GrayDotGameObject, Background.FilledTag [i].transform.position, gameObject.transform.rotation);
				Destroy (Background.FilledTag [i]);
			}
			Background.Moves = 0;
		}

	}
}
