using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private void OnTriggerStay(Collider other)
    {
        IInteractable[] obj = other.GetComponentsInChildren<IInteractable>();
        if(obj != null)
            if (Input.GetKeyDown(KeyCode.E))
                foreach(IInteractable e in obj)
                    e.Interact(gameObject);
    }
}
