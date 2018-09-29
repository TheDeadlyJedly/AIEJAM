using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour {

    public GameObject arrow;
    public GameObject bow;
    public Transform bowPos;
    public int projectileSpeed = 10;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
            Rigidbody fireArrow;
            fireArrow = Instantiate(arrow, bowPos.position, bowPos.rotation).GetComponent<Rigidbody>();
            fireArrow.AddForce(transform.forward * projectileSpeed, ForceMode.Impulse);
            //GetComponent<Rigidbody>().AddForce(Vector3.forward * projectileSpeed);
        }
	}
}
