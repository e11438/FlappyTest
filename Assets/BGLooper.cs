 using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

	int numBGPanels=8;

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D collider){
	
		Debug.Log ("Triggered:" + collider.name);

		float widthOfBGObj = ((BoxCollider2D)collider).size.x;


		string name = ((BoxCollider2D)collider).name;
		Vector3 pos = collider.transform.position;
		if (name != "Sky") {
			pos.x += (widthOfBGObj * numBGPanels-0.4f);
		} else {
			pos.x += (widthOfBGObj*2-0.4f);
		}

		collider.transform.position = pos;
	}
}
