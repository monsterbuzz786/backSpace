﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clouds : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.up * Time.deltaTime*14;
		transform.position += Vector3.back * Time.deltaTime*14;//translate position up

	}
}
