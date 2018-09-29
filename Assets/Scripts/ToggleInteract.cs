using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ToggleInteract : MonoBehaviour, IInteractable {
    public bool _state = false;
    public UnityEvent _onOnState;
    public UnityEvent _onOffState;
    public bool Interact(GameObject g)
    {
        _state = !_state;
        if (_state) _onOnState.Invoke();
        else _onOffState.Invoke();
        return true;
    }
    
}
