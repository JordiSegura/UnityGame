using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	/*FixedUpdate, se carga antes que las fisicas de los objetos en pantalla,en el caso de que tenga
	Si no afectamos a la fisica, antes de dibujar se llama al Update una vez las fisicas han sido calculadas. Exceptuando a la camara (va en el LatUpdate))
	Capturamos el rigidBody*/
	private Rigidbody rb;
	public float speed = 1.0f;

	void Start () {
		//Le decimos que busque el RigidBody existente
		rb = GetComponent<Rigidbody> ();
		
	}
	
	void FixedUpdate () {
	//Aplicamos la fuerza sobre el RigidBody
		//Tomamos el impulso dado por el usuario
		float x = Input.GetAxis ("Horizontal");
		float z= Input.GetAxis ("Vertical");

		Vector3 force = new Vector3 (x, 0.0f, z);

		rb.AddForce (force*speed);


		
		
	}
}
