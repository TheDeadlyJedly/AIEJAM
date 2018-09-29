using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {
    Dictionary<Transform, Transform> _parents = new Dictionary<Transform, Transform>();
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.parent != null)
            _parents.Add(other.transform, other.transform.parent);
        other.transform.parent = this.transform;
    }
    private void OnTriggerExit(Collider other)
    {
        if (_parents.ContainsKey(other.transform))
        {
            other.transform.parent = _parents[other.transform];
            _parents.Remove(other.transform);
        }
        else
        {
            other.transform.parent = null;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
    }



    [SerializeField] private Vector3 _startPoint;
    [SerializeField] private Vector3 _endPoint;

    public float _time;
    private float _timer;
    private bool _forward = true;
    private void Update()
    {

        if (_forward && _timer < _time)
        {
            _timer += Time.deltaTime;
            if (_timer >= _time) _forward = false;

        }else if(!_forward && _timer > 0)
        {
            _timer -= Time.deltaTime;
            if (_timer <= 0) _forward = true;
        }
        


        transform.position = Vector3.Lerp(_startPoint, _endPoint, _timer / _time);
    }

    [ContextMenu("Set Start")]
    public void SetStart()
    {
        _startPoint = transform.position;
    }
    [ContextMenu("Set End")]
    public void SetEnd()
    {
        _endPoint = transform.position;
    }
}
