﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveCap : MonoBehaviour {

	 
	
	// Update is called once per frame
	void Update () {
        if (RotateAround.instance.move == true) GetComponent<Animator>().enabled = false;
	}
}