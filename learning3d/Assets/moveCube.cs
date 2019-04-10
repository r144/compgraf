using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movcube : MonoBehaviour {

    public Transform objeto;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 posRelativa = objeto.position - transform.position;
        transform.rotation = Quaternion.LookRotation(posRelativa);
	}
}
