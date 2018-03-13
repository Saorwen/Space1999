using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSpawner : MonoBehaviour {

	public float gap = 20;
	public float Followers = 2;

	public GameObject prefab;

	void Awake() {
		GameObject leader = Instantiate (prefab, transform.position, transform.rotation, transform) as GameObject;

		for (int i = 1; i < ((Followers + 1) / 2); i++) {
			GameObject follower = Instantiate (prefab, leader.transform.position + new Vector3(gap*i, 0, gap*i), leader.transform.rotation, transform) as GameObject;
		}
		for (int i = 1; i < ((Followers + 1) / 2); i++) {
			GameObject follower = Instantiate (prefab, leader.transform.position + new Vector3(gap*i, 0, gap*-i), leader.transform.rotation, transform) as GameObject;
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
