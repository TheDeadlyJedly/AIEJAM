using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour {

	public GameObject arrow;
	public GameObject bow;
	public Transform bowPos;
	public int projectileSpeed = 10;

	private Bow bowReference;

	void SpawnArrow()
	{
		Rigidbody fireArrow;
		fireArrow = Instantiate (arrow, bowPos.position, bowPos.rotation).GetComponent<Rigidbody> ();
		fireArrow.AddForce (transform.forward * projectileSpeed, ForceMode.Impulse);

	}
}
