using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanger : MonoBehaviour
{   
    public AudioSource Btn;
    public GameObject gameoverUi;
    private void Start() {
        Time.timeScale=1;
    }
    public void GameOver(){
        gameoverUi.SetActive(true);
        Time.timeScale=0;
    }
    public void reset(){
        Btn.Play();
        SceneManager.LoadScene(1);
    }
}
