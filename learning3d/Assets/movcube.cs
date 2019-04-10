using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour {

    public Transform objeto;
    public float velRot;
    public float acc;
    // Use this for initialization
    void Start () {
       velRot = 10f;
        acc = 10f;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 posRelativa = objeto.position - transform.position;

        transform.localPosition.Set(posRelativa.x, posRelativa.y,posRelativa.z-3);
        
        transform.rotation = Quaternion.LookRotation(posRelativa);
	}
}
