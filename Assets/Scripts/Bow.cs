using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bow : MonoBehaviour {

    public GameObject arrow;
    public GameObject bow;
    public Transform bowPos;
    public int projectileSpeed = 10;

    public float coolDown = 1;
    public Slider coolDownSlider;
	
	// Update is called once per frame
	void Update () {
        if(coolDown > 0) coolDown -= Time.deltaTime;
        Debug.Log("Cooldown: " + coolDown);
        if(coolDownSlider != null) coolDownSlider.value = coolDown;
        if (Input.GetKeyDown(KeyCode.Mouse0) && (coolDown <= 0)) {
            coolDown = 1;
            Rigidbody fireArrow;
            fireArrow = Instantiate(arrow, bowPos.position, bowPos.rotation).GetComponent<Rigidbody>();
            fireArrow.AddForce(transform.forward * projectileSpeed, ForceMode.Impulse);
            //GetComponent<Rigidbody>().AddForce(Vector3.forward * projectileSpeed);
            
        }
	}
}
