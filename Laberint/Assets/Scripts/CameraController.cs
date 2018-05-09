using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    //Guardamos la distancia relativa entre la camara y el jugador conla variable offset

    private Vector3 offset;

    //Obtenemos el objeto player
    public GameObject player;


	void Start () {
        //Tomamos la posicion de la camara con la del jugador para mantener una distancia constante
        offset = transform.position - player.transform.position;
		
	}
	
	// Update is called once per frame
    //El late update para aplicar comportamiento a la cámara
	void LateUpdate () {
        //modificamos la posicion de la camara
        transform.position = player.transform.position + offset;
		
	}
}
