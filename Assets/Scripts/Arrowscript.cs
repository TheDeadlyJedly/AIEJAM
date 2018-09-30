using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrowscript : MonoBehaviour {


    TrailRenderer _renderer;
    float _renTimer;
    private void Awake() {
        Destroy(gameObject, 5);
        
        
        _renderer = GetComponentInChildren<TrailRenderer>();
        _renTimer = _renderer.time;
        Destroy(_renderer.gameObject, 5);
    }

    private void OnCollisionEnter(Collision collision)
    {
        _renderer.transform.SetParent(null);
        IHitable[] hits = collision.gameObject.GetComponents<IHitable>();
        foreach (IHitable h in hits)
        {
            if (h != null)
            {
                h.Hit(1);
            }
        }

        GetComponent<Rigidbody>().isKinematic = true;
        transform.SetParent(collision.transform);
        GetComponent<Collider>().enabled = false;

        StartCoroutine(Fade(5));
    }

    public IEnumerator Fade(int time)
    {
        float timer = time;
        while(time > 0)
        {
            timer -= Time.deltaTime;
            _renderer.time = Mathf.Lerp(0, _renTimer, timer);
            yield return new WaitForEndOfFrame();
        }
    }
}
