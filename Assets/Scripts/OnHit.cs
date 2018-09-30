using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class OnHit : MonoBehaviour, IHitable
{
    public UnityEvent _onHit;
    public bool Hit(int amt)
    {
        _onHit.Invoke();
        return true;
    }
}
