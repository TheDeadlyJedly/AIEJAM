using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrowscript : MonoBehaviour {

    private void Awake() {
        Invoke("DestroyArrow", 5f);
    }

    public void DestroyArrow() {
        Destroy(gameObject);
    }
}
