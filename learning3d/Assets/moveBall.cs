﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall: MonoBehaviour {

    public float velRot;
    public float velTrans;
	// Use this for initialization
	void Start () {
        velRot = 70f;
        velTrans = 5f;
	}
	
	// Update is called once per frame
	void Update () {
//        transform.Rotate(0, velRot * Time.deltaTime, 0);
//        transform.Translate(-velTrans * Time.deltaTime, 0, 0);
	}
}
