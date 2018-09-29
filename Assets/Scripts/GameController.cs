using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    float timer;
    public Text timeDisp;

	// Update is called once per frame
	void Update () {
        timer += 1 * (Time.smoothDeltaTime);
        timeDisp.text = ("" + Mathf.Floor(timer));
	}
}
