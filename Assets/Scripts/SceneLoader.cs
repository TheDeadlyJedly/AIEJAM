﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour {
    public string _sceneName;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(_sceneName);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(_sceneName);
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
