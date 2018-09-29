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

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("HIT");
        IHitable hit = collision.gameObject.GetComponent<IHitable>();
        if (hit != null)
            hit.Hit(1);
    }
}
