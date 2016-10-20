using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.down * Time.deltaTime*14); //transform rotation backward's
		//stop when hit or inspecting
	}
}
