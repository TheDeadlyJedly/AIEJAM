using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {
    public Teleporter _exit;

    public Transform _spawnPoint;

    public List<GameObject> _telported = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if(_exit != null && !_telported.Contains(other.gameObject))
        {
            other.gameObject.transform.position = _exit._spawnPoint.position;
            _exit._telported.Add(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        _telported.Remove(other.gameObject);
    }
}
