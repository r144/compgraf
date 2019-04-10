using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAirplane : MonoBehaviour {
    public float acc;
    public float velrotX;
    public float velrotY;
	// Use this for initialization
	void Start () {
        acc = 10f;
        velrotX = 5f;
        velrotY = 4f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector3(0, 0, acc * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(-velrotX * Time.deltaTime, 0, 0));
        }
        else if(transform.localRotation.x < 0)
        {
            transform.Rotate(new Vector3(velrotX * Time.deltaTime, 0, 0));

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -velrotX * Time.deltaTime, 0));
            transform.Rotate(new Vector3(0, 0, velrotX * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, velrotX * Time.deltaTime, 0));
            transform.Rotate(new Vector3(0, 0, -velrotX * Time.deltaTime));
        }
    }
}
