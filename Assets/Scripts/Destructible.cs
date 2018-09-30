using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Destructible : MonoBehaviour, IHitable {

    public UnityEvent _onDestroy;
    public int _HP = 3;

    public bool Hit(int amt)
    {
        _HP -= amt;
        if(_HP <= 0)
        {
            _onDestroy.Invoke();
            Destroy(gameObject);
            return true;
        }
        return false;
    }


    [ContextMenu("Hit")]
    public void FakeHit()
    {
        Hit(1);
    }
}
