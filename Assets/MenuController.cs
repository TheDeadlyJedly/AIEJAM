using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public GameObject pause;

    public void QuitGame() {
        Application.Quit();
    }
    public void StartGame() {
        SceneManager.LoadScene("Greybox");
    }
    public void MainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
    public void Update() {
        if (Input.GetKeyDown(KeyCode.Escape) && pause.activeInHierarchy == false) {
            pause.SetActive(true);
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pause.activeInHierarchy == true) {
            Unpause();
        }
    }
    public void Unpause() {
        Time.timeScale = 1;
        pause.SetActive(false);
    }
}
