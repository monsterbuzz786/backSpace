using UnityEngine;
using System.Collections;


public class dudewalk : MonoBehaviour {
	void OnTriggerEnter(Collider other){
		if (other.tag == "Score") {
			Destroy (other.gameObject);
		}
		if (other.tag == "Health") {
			Destroy (other.gameObject);
		}
		if (other.tag == "Enemy") {
			Destroy (other.gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		string dudefight = "false";
	}

	public float horizontalSpeed = 0.5F;
	public float verticalSpeed = 0.5F;

	// Update is called once per frame
	void Update () {
		//get input
		float h = horizontalSpeed * Input.GetAxis("Vertical");
		float v = verticalSpeed * Input.GetAxis("Horizontal");
		//translate position within frustrum 'screen
		transform.position += new Vector3(v,h,0);
		//create shoot func
		//create jump animation
	}
}
