using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Bow : MonoBehaviour {

    public float coolDown = 1;
    public Slider coolDownSlider;

	private bool stringPulled = false;

	public UnityEvent onPull;
	public UnityEvent onRelease;

	void Start()
	{

	}
	
	// Update is called once per frame
	void Update () {
        if (coolDown < 1) coolDown += Time.deltaTime;
        //Debug.Log("Cooldown: " + coolDown);
        if(coolDownSlider != null) coolDownSlider.value = coolDown;

//		if (Input.GetKeyDown(KeyCode.Mouse0) && (coolDown >= 1)) {
//			coolDown = 0;
//			Rigidbody fireArrow;
//			fireArrow = Instantiate(arrow, bowPos.position, bowPos.rotation).GetComponent<Rigidbody>();
//			fireArrow.AddForce(transform.forward * projectileSpeed, ForceMode.Impulse);
//			stringPulled = true;
//			onPull.Invoke ();
//		}

		if (coolDown >= 1)
		{
			if (stringPulled == false && Input.GetKey (KeyCode.Mouse0)) 
			{
				onPull.Invoke ();
				stringPulled = true;
			} 
			else if (stringPulled == true && !Input.GetKey (KeyCode.Mouse0)) 
			{
				coolDown = 0;
				stringPulled = false;
				onRelease.Invoke ();
			}
		}
	}
}
