using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundPlayer : MonoBehaviour {
    public AudioClip[] _setSounds;
    public AudioClip[] _randomSounds;
    private AudioSource _source;
    private void Start()
    {
        _source = GetComponent<AudioSource>();
        
    }

    public void PlayRandom()
    {
        int index = Random.Range(0, _randomSounds.Length);
        PlaySound(index, _randomSounds);
    }
    public void PlaySound(int index)
    {
        PlaySound(index, _setSounds);
    }
    public void PlaySound(int index, AudioClip[] list)
    {
        if (index >= 0 && index < list.Length && list[index] != null)
        {
            _source.clip = list[index];
            _source.Play();
        }
        else
        {
            Debug.Log("Bad Index");
        }
    }
    public void CreateSound(int index)
    {

        if (index >= 0 && index < _setSounds.Length && _setSounds[index] != null)
        {
            GameObject g = new GameObject("Audio");
            g.transform.position = this.transform.position;
            AudioSource s = g.AddComponent<AudioSource>();
            s.spatialBlend = 1;

            s.clip = _setSounds[index];
            s.Play();
            Destroy(g, _setSounds[index].length);
        }
    }
}
