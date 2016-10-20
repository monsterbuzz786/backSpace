using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ground : MonoBehaviour {
	public string wb;
	void OnTriggerEnter(Collider other){
		
		wb = "alive";

		if (other.name == "Ground") {
			transform.SetParent (GameObject.Find("Ground").transform);
		}
		if (other.name == "Garbage") {
			Destroy (gameObject);
			wb = "boid";
		}
	}
		
	// Use this for initialization
	void Start () {
		wb = "boid";
	}

	// Update is called once per frame
	void Update () {
		
		if (wb == "alive"){
			wb = "sprite";
		}
		if (wb == "boid") {
			transform.position += Vector3.back * Time.deltaTime*16;
		}
		if (wb == "sprite") {
			transform.rotation = Quaternion.identity;
		}
	}
}
