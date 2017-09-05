using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour {

    public GameObject target;
    Vector3 offset; //deslocamento. Offset serve para armazenar o deslocamento entre a câmera e o jogador. Usado para manter a distância relativa ao jogador

    // Use this for initialization
    void Start () {
        offset = transform.position - target.transform.position;    //inserindo o valor inicial ao offset. 
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void LateUpdate()
    {
        Vector3 desiredPosition = target.transform.position + offset;
        transform.position = desiredPosition;
    }
}
