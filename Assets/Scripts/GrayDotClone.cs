using UnityEngine;
using System.Collections;

public class GrayDotClone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown () {

		if (Background.ChosenColor == "dotted") {
			Background.DottedDotClone = Instantiate (Background.DottedDotGameObject, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
			Background.DottedDotClone.tag = "Dotted";
			Background.DottedTag = GameObject.FindGameObjectsWithTag ("Dotted");
			Destroy (gameObject);
		}
		else if (Background.ChosenColor == "blue") {
			GameObject BlueDotClone;
			BlueDotClone = Instantiate (Background.BlueDotGameObject, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
			BlueDotClone.transform.parent = Background.BlueObject.transform;
			Destroy (gameObject);
		}

	}

	void OnTriggerEnter2D (Collider2D coll) {

		if (coll.gameObject.tag == "Blue") {
			Vector3 pos = gameObject.transform.position;
			Vector3 newpos = new Vector3 (pos.x, pos.y, 0.0f);
			Instantiate (Background.FilledDotGameObject, newpos, gameObject.transform.rotation);		
			Destroy (gameObject);



		}

	}
}
