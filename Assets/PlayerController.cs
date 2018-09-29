using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private void OnTriggerStay(Collider other)
    {
        IInteractable obj = other.GetComponent<IInteractable>();
        if(obj != null)
            if (Input.GetKeyDown(KeyCode.E))
                obj.Interact(gameObject);
    }
}
