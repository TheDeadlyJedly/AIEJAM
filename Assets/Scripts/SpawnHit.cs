using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHit : MonoBehaviour, IHitable {
    public GameObject _spawn;
    public List<GameObject> _spawnedObjs;
    public Transform _spawnLoc;
    public float _spawnTime = 1;//time between spawns

    private float _timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (_timer < _spawnTime)
            _timer += Time.deltaTime;
	}

    public bool Hit(int amt)
    {
        if(_timer >= _spawnTime && _spawn != null)
        {
            _spawnedObjs.Add(Instantiate<GameObject>(_spawn, _spawnLoc.position, _spawnLoc.rotation));
        }
        return true;
    }

    [ContextMenu("Hit")]
    public void FakeHit()
    {
        Hit(1);
    }
}
