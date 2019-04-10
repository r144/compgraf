using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoCamera : MonoBehaviour
{

    public Transform transformacaoCubo;
    public Vector3 distancia;
    public float atraso;

    // Start is called before the first frame update
    void Start()
    {
        distancia = new Vector3(0, 1f, -2.5f);
        atraso = 0.1f;
    }

    // LateUpdate is called after Update
    void LateUpdate()
    {
        Vector3 posicaoCamera = transformacaoCubo.position + distancia;
        //transform.position = posicaoCamera;
        transform.position = Vector3.Lerp(transform.position, posicaoCamera, atraso);
        transform.LookAt(transformacaoCubo);
    }

}
