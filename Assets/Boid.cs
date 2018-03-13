using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour {

	List<steeringBehaviour> behaviours = new List<steeringBehaviour>();

	public float mass = 1.0f;
	public float maxSpeed = 10.0f;

	Vector3 force = Vector3.zero;
	Vector3 accelaration = Vector3.zero;
	Vector3 velocity = Vector3.zero;

	Vector3 target;

	// Use this for initialization
	void Start () {
		steeringBehaviour[] behaviours = GetComponents<steeringBehaviour> ();
		foreach (steeringBehaviour b in behaviours) {
			
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
