using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAirplane : MonoBehaviour {
    public float acc;
    public float velocidade;
    public float velrotX;
    public float velrotY;
    public GameObject aviao;
	// Use this for initialization
	void Start () {
        acc = 0;
        velrotX = 5f;
        velrotY = 4f;
        velocidade = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        movimentaAviao();

        aviao.transform.Translate(new Vector3(0, 0, (velocidade * acc) * Time.deltaTime));

        fisicaSimulada();
        if (Input.GetKey(KeyCode.W))
        {
            if (velrotX < 10)
            {
                velrotX = velrotX + Time.deltaTime;
                transform.Rotate(new Vector3(-velrotX * Time.deltaTime, 0, 0));
            }
            // transform.Translate(new Vector3(0, velrotX * Time.deltaTime * 2, 0));
        }
        else
            if(velrotX > 10)
                velrotX--;
        else if (transform.localRotation.x < 90)
        {
            aviao.transform.Rotate(new Vector3(velrotX * Time.deltaTime, 0, 0));

        }

        
    }

    private void fisicaSimulada()
    {
        throw new NotImplementedException();
    }

    private void movimentaAviao()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (acc < 300) {
                acc = velocidade/Time.deltaTime;
                velocidade = acc * Time.deltaTime;
            }
        }
        else if (acc > 0)
        {
            acc--;
        }
        if (Input.GetKey(KeyCode.A))
        {
            aviao.transform.Rotate(new Vector3(0, -velrotX * Time.deltaTime, 0));
            aviao.transform.Rotate(new Vector3(0, 0, velrotX * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            aviao.transform.Rotate(new Vector3(0, velrotX * Time.deltaTime, 0));
            aviao.transform.Rotate(new Vector3(0, 0, -velrotX * Time.deltaTime));
        }
    }
}
